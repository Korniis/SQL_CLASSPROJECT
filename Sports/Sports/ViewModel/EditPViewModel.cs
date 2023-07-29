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
    public class EditPViewModel : ViewModelBase
    {
        public EditPViewModel()
        {
            PrizeTables = new PrizeTableService().Select();
           
        }
        private List<PrizeTable> prizeTables;

        public List<PrizeTable> PrizeTables
        {
            get { return prizeTables; }
            set { prizeTables = value; RaisePropertyChanged(); }
        }
        private AthleteTable athlete = new AthleteTable();

        public AthleteTable Athlete
        {
            get { return athlete; }
            set { athlete = value; RaisePropertyChanged(); }
        }

        public RelayCommand<Window> EditCommand
        {
            get
            {
                var command = new RelayCommand<Window>((Window) =>
                {


                    try
                    {
                        int count = new AthleteTableService().Update(Athlete);
                    }
                    catch { MessageBox.Show("lost"); }
                    Window.Close();

                });

                return command;

            }
        }

    }
}
