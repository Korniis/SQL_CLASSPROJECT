using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports
{
    public class AppData:ViewModelBase
    {
        public  static AppData  Instance { get; private set; } = new Lazy<AppData> ().Value;

        private UserInfo user = new UserInfo() { Name = "2", Password = "2" };
        public UserInfo User
        {
            get { return user; }
            set { user = value; RaisePropertyChanged(); }
        }
    }
}
