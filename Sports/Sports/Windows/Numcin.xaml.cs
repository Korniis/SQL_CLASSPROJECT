using Sports.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Sports.Windows
{
    /// <summary>
    /// Numcin.xaml 的交互逻辑
    /// </summary>
    public partial class Numcin : Window
    {
        public Numcin()
        {
            InitializeComponent();
        }
        private ClassTable classcg;

        public ClassTable Classcg
        {
            get { return classcg; }
            set { classcg = value; }
        }


        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex re = new Regex("[^0-9]+");
            e.Handled = re.IsMatch(e.Text);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Num.Text))
            {
                return;
            }
            int num = int.Parse(Num.Text);
            if (num != 0)
            {
                Classcg.ClassSize = num;
            }
            else 
            {
                MessageBox.Show("请输入大于0数字");
            }
            int count = new ClassTableService().Update(Classcg);
            this.Close();
        }
    }
}
