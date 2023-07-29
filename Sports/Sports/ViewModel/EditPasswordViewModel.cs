using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Sports.Model;
using Sports.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sports.ViewModel
{
    public class EditPasswordViewModel : ViewModelBase
    {

        private EditPasswordModel passwordmodel = new EditPasswordModel();
        public EditPasswordModel Passwordmodel
        {
            get { return passwordmodel; }
            set { passwordmodel = value; RaisePropertyChanged(); }
        }
        public RelayCommand<Window> EditPasswordCommand
        {
            get
            {
                var command = new RelayCommand<Window>((Window) =>
                {
                    if (string.IsNullOrEmpty(passwordmodel.Oldpassword) || string.IsNullOrEmpty(passwordmodel.Newpassword) || string.IsNullOrEmpty(passwordmodel.SPassword) )
                    { MessageBox.Show("请输入正确信息"); return; }
                    if (AppData.Instance.User.Password != passwordmodel.Oldpassword)
                    { MessageBox.Show("请输入正确密码"); return; }
                    if (passwordmodel.Newpassword != passwordmodel.SPassword)
                    { MessageBox.Show("密码不一致"); return; }
                    var user=AppData.Instance.User;
                    user.Password = passwordmodel.Newpassword;
                    UserInfoService userInfoService = new UserInfoService();
                    int count = userInfoService.Update(user);
              
               
                    if (count >0)
                    {
                        MessageBox.Show("修改成功");
                      

                        MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();
                        Window.Close();
                    }
                    else
                        MessageBox.Show("修改失败");





                });
                return command;
            }
        }
    }

}
