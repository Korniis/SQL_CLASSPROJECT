using Sports.ViewModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sports.View
{
    /// <summary>
    /// PlayerView.xaml 的交互逻辑
    /// </summary>
    public partial class PlayerView : UserControl
    {
        public PlayerView()
        {
            InitializeComponent();
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex re = new Regex("[^0-9]+");
            e.Handled = re.IsMatch(e.Text);

        }

        private void OnDataGridPrinting(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.PrintDialog Printed = new System.Windows.Controls.PrintDialog();
            if ((bool)Printed.ShowDialog().GetValueOrDefault())
            {
                Size pageSize = new Size(Printed.PrintableAreaWidth, Printed.PrintableAreaHeight);
                // sizing of the element.
                datagrid1.Measure(pageSize);
                datagrid1.Arrange(new Rect(5, 5, pageSize.Width, pageSize.Height));
                Printed.PrintVisual(datagrid1, "asd");
            }
        }
    }
}
