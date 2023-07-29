using Sports.View;
using Sports.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
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
using System.Xml.Linq;

namespace Sports
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()

        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            container.Content = new IndexView();
        }
        //修改密码
        private void TextBlock_MouseUp(object sender, MouseButtonEventArgs e)
        {
            var Window = new EditPassword();
            Window.ShowDialog();

        }

        private void Quit_MouseUp_1(object sender, MouseButtonEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void TextBlock_MouseUp_1(object sender, MouseButtonEventArgs e)
        {

        }


        private void PlayerView_Checked(object sender, RoutedEventArgs e)
        {
            

            var button = sender as RadioButton;
            if (button == null) return;
            Assembly assembly = Assembly.GetExecutingAssembly();
            var space=System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Namespace;
            var path=space+ ".View." + button.Name;
            dynamic obj = assembly.CreateInstance(path);
            if(obj==null) return;
            container.Content = obj;
        }

        private void ColorZone_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            container.Content = new IndexView();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
