using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Sports.Service;
using Sports.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Sports.ViewModel
{
    public class ClassViewModel : ViewModelBase
    {
        public ClassViewModel()
        {
            ClassTables = new ClassTableService().Select();
        }
        private ClassTable _classTable = new ClassTable();

        public ClassTable _ClassTable
        {
            get { return _classTable; }
            set { _classTable = value; RaisePropertyChanged(); }
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

                    if (_ClassTable.ClassID == 0 || _ClassTable.ClassSize == 0 || string.IsNullOrEmpty(_ClassTable.ClassName))
                    {
                        MessageBox.Show("请正确输入信息");
                        return;
                    }
                    ClassTableService service = new ClassTableService();
                    try { service.Insert(_ClassTable); }
                    catch
                    {
                        MessageBox.Show("请查看是否有重复或错误编号");
                        return;
                    }


                    ClassTables = new ClassTableService().Select();
                });


                return command;
            }

        }
        public RelayCommand<Button> DeleCommand
        {
            get
            {
                var command = new RelayCommand<Button>((view) =>
                {

                    if (MessageBox.Show("是否删除", "", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        var old = view.Tag as ClassTable;
                        ClassTableService service = new ClassTableService();
                        try { service.Delete(old); }
                        catch
                        {

                            MessageBox.Show("有表在占用该数据 无法删掉");

                        }


                        ClassTables = new ClassTableService().Select();
                    }
                });


                return command;
            }
        }
      
        public RelayCommand<Button> ChangeCommand
        {
            get
            {
                var command = new RelayCommand<Button>((view) =>
                {
                    var classucg = view.Tag as ClassTable;
                    if (classucg == null) { return; }
                    var _window = new Numcin();
                    _window.Classcg = classucg;
                    _window.ShowDialog();

                    ClassTables = new ClassTableService().Select();


                });


                return command;
            }

        }

    }
}
