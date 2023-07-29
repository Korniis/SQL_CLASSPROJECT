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

using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sports.View
{
    /// <summary>
    /// RefereeView.xaml 的交互逻辑
    /// </summary>
    public partial class RefereeView : UserControl
    {
        public RefereeView()
        {
            InitializeComponent();
        }

        private void TextBox_PreviewTextInput (object sender, TextChangedEventArgs e)
        {
          /*  Regex re = new Regex("[^0-9]+");
            e.Handled = re.IsMatch(e.Text);*/

        }

    }
}
