using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// PrizeTableView.xaml 的交互逻辑
    /// </summary>
    public partial class PrizeTableView : UserControl
    {
        public PrizeTableView()
        {
            InitializeComponent();
            this.CalssPrize.LoadingRow += new EventHandler<DataGridRowEventArgs>(this.DataGridSoftware_LoadingRow);
        }
        private void OnDataGridPrinting(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.PrintDialog Printed = new System.Windows.Controls.PrintDialog();
            if ((bool)Printed.ShowDialog().GetValueOrDefault())
            {
                Size pageSize = new Size(Printed.PrintableAreaWidth, Printed.PrintableAreaHeight);
                // sizing of the element.
                CalssPrize.Measure(pageSize);
                CalssPrize.Arrange(new Rect(5, 5, pageSize.Width, pageSize.Height));
                Printed.PrintVisual(CalssPrize, "asd");
            }
        }

            private void DataGridSoftware_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = e.Row.GetIndex() + 1;
        }

      
    }
}
