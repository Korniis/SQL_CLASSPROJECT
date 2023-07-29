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
    public class EditMatchViewModel:ViewModelBase
    {
        private MatchTable matchType=new MatchTable();

		public MatchTable MatchType
        {
			get { return matchType; }
			set { matchType = value;  RaisePropertyChanged(); }

		}
		public RelayCommand<Window> EditCommand
		{
            get
            {
                var command = new RelayCommand<Window>((Window) =>
                {


                    if (String.IsNullOrEmpty(matchType.MatchName) || matchType.MatchID == 0 || String.IsNullOrEmpty(matchType.Gender))
                    {
                        MessageBox.Show("输入框 和选项不能为空");
                        return;

                    }
                    if (matchType.Max == 0)
                    {
                        MessageBox.Show("人数不能为0");
                        return;
                    }

                    MatchTableService service = new MatchTableService();
                    int count = 0;
               
                     count = service.Update(MatchType); 


                    if (count > 0)
                    {
                   
                        MessageBox.Show("成功");
                    



                    }
                    else
                    {
                        MessageBox.Show("错误");

                    }

                    Window.Close();
                });
               
                return command;

            }
        }
	}
}
