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

namespace Sports.Control
{
    /// <summary>
    /// ButtonCard.xaml 的交互逻辑
    /// </summary>
    public partial class ButtonCard : UserControl
    {
        public ButtonCard()
        {
            InitializeComponent();
        }


        public string  Logo
        {
            get { return (string)GetValue( LogoProperty); }
            set { SetValue( LogoProperty, value); }
        }

        // Using a DependencyProperty as the backing store for  Logo.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty  LogoProperty =
            DependencyProperty.Register(" Logo", typeof(string), typeof(ButtonCard), new PropertyMetadata("😊", new PropertyChangedCallback(OnLogoPropertyChangedCallback )));

        private static void OnLogoPropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is ButtonCard button)
            {
                button.textBlockLogo.Text = e.NewValue.ToString();
            
            }
            
        }


        public new string Content
        {
            get { return (string)GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for  Content.  This enables animation, styling, binding, etc...
        public static new readonly DependencyProperty ContentProperty =
            DependencyProperty.Register("Content", typeof(string), typeof(ButtonCard), new PropertyMetadata("报名项目", new PropertyChangedCallback(OnContentPropertyChangedCallback)));

        private static  void OnContentPropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is ButtonCard button)
            {
                button.textBlockContent.Text = e.NewValue.ToString();

            }

        }

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for  Title.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register(" Title", typeof(string), typeof(ButtonCard), new PropertyMetadata("报名项目", new PropertyChangedCallback(OnTitlePropertyChangedCallback)));

        private static void OnTitlePropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is ButtonCard button)
            {
                button.textBlockTitle.Text = e.NewValue.ToString();

            }

        }
    }
}
