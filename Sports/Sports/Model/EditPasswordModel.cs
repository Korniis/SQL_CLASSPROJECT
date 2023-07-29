using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports.Model
{
    public class EditPasswordModel:ObservableObject
    {
		private string oldpassword="";

		public string Oldpassword
        {
			get { return oldpassword; }
			set { oldpassword = value;  RaisePropertyChanged(); }
		}

        private string newpassword = "";

        public string Newpassword
        {
            get { return newpassword; }
            set { newpassword = value; RaisePropertyChanged(); }
        }
        private string  spassword = "";

        public string SPassword
        {
            get { return spassword; }
            set { spassword = value; RaisePropertyChanged(); }
        }


    }
}
