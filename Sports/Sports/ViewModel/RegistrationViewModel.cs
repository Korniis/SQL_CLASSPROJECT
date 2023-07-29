using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Sports.Service;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Sports.ViewModel
{
    public class RegistrationViewModel : ViewModelBase
    {
        public RegistrationViewModel()
        {
            RegistrationTables = new RegistrationTableService().Select();
            ClassTables = new ClassTableService().Select();
        }

        private RegistrationTable registration = new RegistrationTable();

        public RegistrationTable Registration
        {
            get { return registration; }
            set { registration = value; RaisePropertyChanged(); }
        }

        private List<RegistrationTable> registrationTables;

        public List<RegistrationTable> RegistrationTables
        {
            get { return registrationTables; }
            set { registrationTables = value; RaisePropertyChanged(); }
        }
        private List<ClassTable> classTables;

        public List<ClassTable> ClassTables
        {
            get { return classTables; }
            set { classTables = value; RaisePropertyChanged(); }
        }


        public RelayCommand<UserControl> AddCommand
        {
            get
            {
                var command = new RelayCommand<UserControl>((view) =>
                {
                    if (Registration.SNO == 0 || String.IsNullOrWhiteSpace(Registration.Name) || String.IsNullOrEmpty(Registration.Name) || String.IsNullOrEmpty(Registration.Gender))
                    {
                        MessageBox.Show(" 输入有问题 请检查是否有错填漏填");
                        return;
                    }
                    RegistrationTableService service = new RegistrationTableService();
                    if (service.Select(Registration.SNO) != null)
                    {
                        MessageBox.Show(" 用户已存在");
                        return;
                    }
                    
                    RegistrationTables = new RegistrationTableService().Select();
                    int num = RegistrationTables.Count(t => t.ClassID == Registration.ClassID);

                    Registration.RegistrationTime = DateTime.Now;

                    int count = 0;
                    try { count = service.Insert(Registration); }
                    catch 
                    {
                        MessageBox.Show("班级人数够了");

                        return;

                    }

                    if (count > 0)
                    {


                        MessageBox.Show("操作成功");

                        RegistrationTables = new RegistrationTableService().Select();

                        Registration = new RegistrationTable();
                    }
                    else
                    {
                        MessageBox.Show("输入错误或项目已存在");

                    }




                });
                return command;

            }

        }

    }
}
