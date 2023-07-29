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
    public class PostViewModel : ViewModelBase
    {
        public PostViewModel()
        {

            PrizeTables = new PrizeTableService().Select();
            MatchTableList = new MatchTableService().Select();

            
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

        public List<MatchTable> matchTableList = new List<MatchTable>();
        public List<MatchTable> MatchTableList
        {
            get { return matchTableList; }
            set { matchTableList = value; RaisePropertyChanged(); }
        }

        private PrizeTable prizeTable;

        public PrizeTable PrizeTable
        {
            get { return prizeTable; }
            set { prizeTable = value; RaisePropertyChanged(); }
        }

        private RefereeTable referee = new RefereeTable() ;
        public RefereeTable Referee
        {
            get { return referee; }
            set { referee = value; RaisePropertyChanged(); }
        }

        private List<PrizeTable> prizeTables;

        public List<PrizeTable> PrizeTables
        {
            get { return prizeTables; }
            set { prizeTables = value; RaisePropertyChanged(); }

        }
        public RelayCommand<UserControl> SelectCommand

        {
            get
            {
                var Command = new RelayCommand<UserControl>((obj) =>
                {
                    AthleteTables = new AthleteTableService().Select().FindAll(t => t.MatchID == Athlete.MatchID);

                    Referee = new RefereeTableService().SelectMatch(Athlete.MatchID);
                });
                
                return Command;

            }
        }



        public RelayCommand<UserControl> OrderByDownCommand

        {
            get
            {
                var Command = new RelayCommand<UserControl>((obj) =>
                {
                    AthleteTables = AthleteTables.OrderByDescending(t => t.Grade).ToList();
                });

                return Command;

            }
        }

        public RelayCommand<UserControl> OrderByCommand

        {
            get
            {
                var Command = new RelayCommand<UserControl>((obj) =>
                {
                    AthleteTables = AthleteTables.OrderBy(t => t.Grade).ToList();
                });

                return Command;

            }
        }
        public RelayCommand<Button> EditCommands
        {
            get
            {
                var command = new RelayCommand<Button>((view) =>
                {

                    if (MessageBox.Show("是否拿奖", "", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        var old = view.Tag as AthleteTable;
                        if (old == null) { return; }
                        var model = ServiceLocator.Current.GetInstance<EditPViewModel>();
                        model.Athlete = old;

                        var window = new EditP();
                        window.ShowDialog();

                        AthleteTables = new AthleteTableService().Select().FindAll(t => t.MatchID == Athlete.MatchID);


                    }

                });
                return command;


            }


        }
        public RelayCommand<UserControl> UpDataCommand

        {
            get
            {
                var Command = new RelayCommand<UserControl>((obj) =>
                {
                    if (AthleteTables is null)
                    {

                        MessageBox.Show("请选择项目");
                        return;
                    }
                    try
                    {

                        int count = new AthleteTableService().Update(AthleteTables);
                    }
                    catch
                    {
                        MessageBox.Show("输入数据有问题");
                    }
                });

                return Command;

            }



        }


    }
}
