using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Sports.Service;
using Sports.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;
using System.Windows.Controls;

namespace Sports.ViewModel
{
    public class RefereeViewModel : ViewModelBase
    {
        public RefereeViewModel()
        {
            RefereeTables = new RefereeTableService().Select();
         
          
        }
        private RefereeTable referee = new RefereeTable() { MatchID = 0 };
        public RefereeTable Referee
        {
            get { return referee;  }
            set { referee = value; RaisePropertyChanged(); }
        }
        private List<RefereeTable> refereeTables = new List<RefereeTable>();
        public List<RefereeTable> RefereeTables
        { get { return refereeTables; } 
          set { refereeTables = value; RaisePropertyChanged(); } 
        }

        public RelayCommand<UserControl> AddCommand
        {
            get
            {
                var command = new RelayCommand<UserControl>((view) =>
                {



                    if (String.IsNullOrEmpty(referee.RefereeName) || referee.RefereeID == 0)
                    {
                        MessageBox.Show("输入框不能为空");
                        return;

                    }


                    RefereeTableService service = new RefereeTableService();
                    MatchTableService service2 = new MatchTableService();
                    int count = 0;
                    if (service.Select(referee.RefereeID) == null)
                    { count = service.Insert(referee); }


                    if (count > 0)
                    {
                        referee.MatchTable = service2.Select(referee.MatchID);
                        RefereeTables = new RefereeTableService().Select();
                    
                        MessageBox.Show("操作成功");
                        referee = new RefereeTable();

                    }
                    else
                    {
                        MessageBox.Show("输入错误或项目已存在");

                    }



                });
                return command;
            }
        }


        public RelayCommand<Button> EditCommand
        {
            get
            {
                var command = new RelayCommand<Button>((view) =>
                {

                    if (MessageBox.Show("是否分配项目", "", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        var old = view.Tag as RefereeTable;
                        if (old == null) { return; }
                        var model = ServiceLocator.Current.GetInstance<EditRefereeViewModel>();
                        model.Referee = old;
                        model.MatchTablelList= new MatchTableService().Select();
                        var window = new EditReferee();
                        window.ShowDialog();

                        RefereeTables = new RefereeTableService().Select();
                

                    }

                });
                return command;


            }


        }
        public RelayCommand<Button> DeleteCommand
        {
            get
            {
                var command = new RelayCommand<Button>((view) =>
                {

                    if (MessageBox.Show("是否删除", "", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        var old = view.Tag as RefereeTable;
                        RefereeTableService service = new RefereeTableService();
                        service.Delete(old);

                        RefereeTables = new RefereeTableService().Select();
                    }

                });
                return command;


            }


        }

    }


    }


