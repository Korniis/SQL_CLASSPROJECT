using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Sports.Service;
using Sports.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace Sports.ViewModel
{
    public class MatchViewModel : ViewModelBase

    {

        public MatchViewModel()
        {
            MatchTableList = new MatchTableService().Select();
            Location = new LocationTableService().Select();
            MatchType.MatchRule = "N";
        }
        private MatchTable matchType = new MatchTable();

        public MatchTable MatchType
        {
            get { return matchType; }
            set { matchType = value; RaisePropertyChanged(); }
        }

        public List<MatchTable> matchTableList = new List<MatchTable>();
        public List<MatchTable> MatchTableList
        {
            get { return matchTableList; }
            set { matchTableList = value; RaisePropertyChanged(); }
        }
        private List<LocationTable> location;

        public List<LocationTable> Location
        {
            get { return location; }
            set { location = value; RaisePropertyChanged(); }
        }


        public RelayCommand<UserControl> AddCommand
        {
            get
            {
                var command = new RelayCommand<UserControl>((view) =>
                 {


                     if (String.IsNullOrEmpty(matchType.MatchName) || matchType.MatchID == 0 )
                     {
                         MessageBox.Show("输入框 和选项不能为空");
                         return;

                     }
                     
                     if (matchType.Max == 0)
                     {
                         MessageBox.Show("人数不能为0");
                         return;
                     }
                     if (String.IsNullOrEmpty(matchType.Gender))
                     {
                         MatchType.Gender = "无"; 
                     }
                     MatchTableService service = new MatchTableService();
                     int count = 0;
                     if (service.Select(matchType.MatchID) == null)
                     { count = service.Insert(MatchType); }


                     if (count >0)
                     {
                         MatchTableList = service.Select();
                         MessageBox.Show("操作成功");
                         MatchType = new MatchTable();
                         MatchType.MatchRule = "N";
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

                    if (MessageBox.Show("是否修改", "", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        var old = view.Tag as MatchTable;
                        if (old == null) { return; }
                        var model = ServiceLocator.Current.GetInstance<EditMatchViewModel>();
                        model.MatchType = old;
                        var window = new EditMatch();
                        window.ShowDialog();

                        MatchTableList = new MatchTableService().Select();
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
                        MatchTableService service = new MatchTableService();
                        var refService = new RefereeTableService();
                        var old = view.Tag as MatchTable;

                        RefereeTable refs = refService.SelectMatch(old.MatchID);


                        if (refs != null)
                        {
                            refs.MatchID = 0;
                            refService.Update(refs);
                        }



                        service.Delete(old);

                        MatchTableList = new MatchTableService().Select();

                    }

                });
                return command;


            }


        }


    }
}
