using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Sports.Service;
using Sports.View;
using Sports.Windows;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;

namespace Sports.ViewModel
{
    public class PlayerViewModel : ViewModelBase
    {
        public PlayerViewModel()
        {
            AthleteTables = new AthleteTableService().Select();
            MatchTables = new MatchTableService().Select();
            ClassTables = new ClassTableService().Select();
            RegistrationTables = new RegistrationTableService().Select();
            

        }
        private AthleteTable athlete = new AthleteTable();

        public AthleteTable Athlete
        {
            get { return athlete; }
            set { athlete = value; RaisePropertyChanged(); }
        }
        private List<AthleteTable> athleteTables;

        public List<AthleteTable> AthleteTables
        {
            get { return athleteTables; }
            set { athleteTables = value; RaisePropertyChanged(); }
        }
        private List<MatchTable> matchTables;

        public List<MatchTable> MatchTables
        {
            get { return matchTables; }
            set { matchTables = value; RaisePropertyChanged(); }
        }
        private List<ClassTable> classTables;

        public List<ClassTable> ClassTables
        {
            get { return classTables; }
            set { classTables = value; RaisePropertyChanged(); }
        }

        private List<RegistrationTable> registrationTables;

        public List<RegistrationTable> RegistrationTables
        {
            get { return registrationTables; }
            set { registrationTables = value; RaisePropertyChanged(); }
        }




        public RelayCommand<UserControl> RECommand

        {
            get
            {
                var Command = new RelayCommand<UserControl>((obj) =>
                {
                    if (!(obj is PlayerView view))
                    {
                        return;

                    }


                    MatchTables = new MatchTableService().Select();
                    ClassTables = new ClassTableService().Select();

                    Athlete = new AthleteTable();
                    view.AthleteNames.Text = "";
                    view.AthleteGnder.Text = "";
                    view.AthleteClass.Text = "";
                });

                return Command;

            }



        }


       
        public RelayCommand<UserControl> ChangeCommand

        {
            get
            {
                var Command = new RelayCommand<UserControl>((obj) =>
                {
                    if (!(obj is PlayerView view))
                    {
                        return;

                    }
                    if (Athlete.SNO == 0)
                    {

                        MessageBox.Show("未查询到");
                    }
                    RegistrationTableService service = new RegistrationTableService();
                    RegistrationTable table = service.Select(Athlete.SNO);
                    if (table == null)
                    {
                        MessageBox.Show("未查询到 " + Athlete.SNO + " 请检查是否注册");
                        view.AthleteNames.Text = "";
                        view.AthleteGnder.Text = "";
                        view.AthleteClass.Text = "";
                        return;

                    }


                    Athlete.ClassID = table.ClassID;
                    Athlete.AthleteName = table.Name;
                    Athlete.Gender = table.Gender;
                    view.AthleteNames.Text = table.Name;
                    view.AthleteGnder.Text = table.Gender;
                    view.AthleteClass.Text = new ClassTableService().Select(Athlete.ClassID).ClassName;
                   
                    AthleteTables = new AthleteTableService().Select().FindAll(t => t.SNO == Athlete.SNO);
                    if (AthleteTables.Count()!=0)
                        MessageBox.Show("查询成功");
                    else 
                    {
                         
                        MessageBox.Show("未找到你的报名历史欢迎报名");
                        AthleteTables = new AthleteTableService().Select();


                    }



                });

                return Command;

            }



        }
        public RelayCommand<UserControl> AddCommand

        {
            get
            {
                var Command = new RelayCommand<UserControl>((obj) =>
                {


                    if (!(obj is PlayerView view))
                    {
                        return;

                    }
                    if (string.IsNullOrEmpty(Athlete.AthleteName) || string.IsNullOrEmpty(Athlete.Gender))
                    {

                        MessageBox.Show("请将信息填写完整");
                        return;
                    }
                    if (Athlete.MatchID == 0)
                    {
                        MessageBox.Show("未选择比赛");
                        return;
                    }

                    int Scount = AthleteTables.Count(t => t.SNO == Athlete.SNO);
                    if (Scount >= 3)
                    {
                        MessageBox.Show("每个人最多报3个");
                        return;
                    }
                    int Mcount = AthleteTables.Count(t => t.MatchID == Athlete.MatchID);
                    if (Mcount >= MatchTables.Find(t => t.MatchID == Athlete.MatchID).Max)
                    {
                        MessageBox.Show("项目名额满了");
                        return;
                    }
                    if (MatchTables.Find(t => t.MatchID == Athlete.MatchID).MatchRule == "Y")
                    {
                        MessageBox.Show("项目结束报名");
                        return;
                    }

                  int Same= AthleteTables.Count(t => t.MatchID == Athlete.MatchID&&  t.SNO == Athlete.SNO);
                    if (Same > 0)
                    {
                        
                        MessageBox.Show("已经报过了");
                        return;
                    }

                    int num = RegistrationTables.Count(t => t.SNO == Athlete.SNO);
                    if (num < 0)
                    {
                        MessageBox.Show("未在注册表中查询到您的信息 请注册");
                        return;


                    }
                    AthleteTableService service = new AthleteTableService();
                    int count = 0;
                    try
                    {
                        count = service.Insert(Athlete);
                    }
                    catch (DbUpdateException ex)
                    {
                        var sqlException = ex.InnerException as SqlException;

                        MessageBox.Show(ex.Message);

                    }
                    if (count > 0)
                    {
                        MessageBox.Show("报名成功 请妥善保管自己运动员ID");

                    }
                    else
                    {
                        MessageBox.Show("请重新检查报名信息 可能有错误");


                    }
                    AthleteTables = new AthleteTableService().Select();
                    Athlete = new AthleteTable();
                    view.AthleteNames.Text = "";
                    view.AthleteGnder.Text = "";
                    view.AthleteClass.Text = "";
                    return;

                });

                return Command;

            }



        }
    }
}
