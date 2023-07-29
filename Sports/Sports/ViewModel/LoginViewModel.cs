
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

namespace Sports.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
        public AppData AppData { get; private set; } = AppData.Instance;

        private UserInfo user = new UserInfo() { Name = "2", Password = "2" };
        public UserInfo User
        {
            get { return user; }
            set { user = value; RaisePropertyChanged(); }
        }

        public RelayCommand<Window> LoginCommand
        {
            get
            {
                var command = new RelayCommand<Window>((Window) =>
                {


                    if (string.IsNullOrEmpty(User.Password) == true || string.IsNullOrEmpty(User.Name) == true)
                    {
                        MessageBox.Show("请输入正确信息");
                        return;

                    }


                    UserInfoService userInfoService = new UserInfoService();
                    var users = userInfoService.Select();
                    var item = users.FirstOrDefault(t => t.Name == User.Name && t.Password == User.Password);
                    if (item != null)
                    {
                        this.AppData.User = item;

                        MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();
                        Window.Close();
                    }
                    else
                        MessageBox.Show("输入账号密码有误");





                });
                return command;
            }
        }

        public RelayCommand<Window> RegisterCommand
        {
            get
            {
                var command = new RelayCommand<Window>((Window) =>
                {


                    Register registerWindow = new Register();




                    registerWindow.ShowDialog();


                }
                );
                return command;
            }
        }

    }
}

