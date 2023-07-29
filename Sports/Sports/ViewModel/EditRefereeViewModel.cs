using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Sports.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sports.ViewModel
{
    public class EditRefereeViewModel : ViewModelBase
    {
       
        private RefereeTable referee = new RefereeTable();

        public RefereeTable Referee
        {
            get { return referee; }
            set { referee = value; RaisePropertyChanged(); }
        }
        private List<MatchTable> matchTablelList;

        public List<MatchTable> MatchTablelList
        {
            get { return matchTablelList; }
            set { matchTablelList = value; RaisePropertyChanged(); }
        }
        public RelayCommand<Window> EditCommand
        {
            get
            {
                var command = new RelayCommand<Window>((Window) =>
                {


                    if (referee == null) return;
                    Referee.MatchTable = null;

                    RefereeTableService refereeTableService = new RefereeTableService();
                    MatchTableService re = new MatchTableService();

                    int count = refereeTableService.Update(Referee);


                    if (count > 0)
                    {
                     

                        MessageBox.Show("操作成功");
                    }
                    else
                    {
                        MessageBox.Show("错误");

                    }

                    Window.Close();
                }
                );
                return command;
            }
        }

    }
}
