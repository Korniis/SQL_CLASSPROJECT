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
using System.Windows.Media;

namespace Sports.ViewModel
{
    public class RegisterViewModel: ViewModelBase
    {
		private UserInfo UserRE = new UserInfo() ;

		public UserInfo userRE
        {
			get { return UserRE; }
			set { UserRE = value; RaisePropertyChanged(); }
        }


        public RelayCommand<Window> RegisterCommand
        {
            get {
                var command = new RelayCommand<Window>((Window) =>
                {

                    if (string.IsNullOrEmpty(userRE.Name) || string.IsNullOrEmpty(userRE.Password)||userRE.Admin==0)
                    {

                        MessageBox.Show("输入不能为空");
                        return;
                        
                    
                    }
                    if (userRE.Name.Length > 20 || userRE.Password.Length > 20)
                    {
                        MessageBox.Show("用户名或密码过长");
                        return;

                    }
                  

                    UserInfoService userInfoService = new UserInfoService();
                    var Sameone = userInfoService.Select();
                    var item = Sameone.FirstOrDefault(t => t.Name == UserRE.Name && t.Password == UserRE.Password);
                    if (item != null)
                    {
                        MessageBox.Show("此用户已存在"); 
                        return;
                    }
                    
                    userInfoService.Insert(userRE);
                    MessageBox.Show("注册成功");
                    Window.Close();
                     


                   
                });


                return command;
            }
        
        }

   

    }
} 
