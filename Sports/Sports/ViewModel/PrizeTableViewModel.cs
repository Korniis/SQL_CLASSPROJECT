using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Sports.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Sports.ViewModel
{
    public class PrizeTableViewModel:ViewModelBase
    {
        public PrizeTableViewModel() {

            AthleteTables=new AthleteTableService().Select();
            ClassTables = new ClassTableService().Select().OrderByDescending(t => t.ClassScore).ToList(); ;
        }
        private List<ClassTable> classTables;

        public List<ClassTable> ClassTables
        {
            get { return classTables; }
            set { classTables = value; RaisePropertyChanged(); }


        }
        private List<AthleteTable> athleteTables;

        public List<AthleteTable> AthleteTables
        {
            get { return athleteTables; }
            set { athleteTables = value; RaisePropertyChanged(); }
        }

        public RelayCommand<UserControl> EditCommand

        {
            get
            {
                var Command = new RelayCommand<UserControl>((obj) =>
                {
                     foreach (var table in classTables)
                    {
                   table.ClassScore = (AthleteTables.Count(x => x.ClassID == table.ClassID && x.PrizeID == "一等奖")*3)+( AthleteTables.Count(x => x.ClassID == table.ClassID && x.PrizeID == "二等奖")*2)+ (AthleteTables.Count(x => x.ClassID == table.ClassID && x.PrizeID == "三等奖"));
                      

                    }
                   var ins = new ClassTableService().Update(ClassTables); 
                    ClassTables= new ClassTableService().Select().OrderByDescending(t=>t.ClassScore).ToList();

                });

                return Command;

            }
        }



    }
}
