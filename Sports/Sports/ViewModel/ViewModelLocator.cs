/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:Sports"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Sports.Windows;

namespace Sports.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            ////if (ViewModelBase.IsInDesignModeStatic)
            ////{
            ////    // Create design time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DesignDataService>();
            ////}
            ////else
            ////{
            ////    // Create run time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DataService>();
            ////}

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<LoginViewModel>();
            SimpleIoc.Default.Register<RegisterViewModel>();
            SimpleIoc.Default.Register<RefereeViewModel>();
            SimpleIoc.Default.Register<MatchViewModel>();
            SimpleIoc.Default.Register<EditPasswordViewModel>();
            SimpleIoc.Default.Register<EditMatchViewModel>();
            SimpleIoc.Default.Register<EditRefereeViewModel>();
            SimpleIoc.Default.Register<PlayerViewModel>();
            SimpleIoc.Default.Register<RegistrationViewModel>();
            SimpleIoc.Default.Register<RegistrationViewModel>();
            SimpleIoc.Default.Register<ClassViewModel>();
            SimpleIoc.Default.Register<PostViewModel>();
            SimpleIoc.Default.Register<PrizeTableViewModel>();
            SimpleIoc.Default.Register<EditPViewModel>();

        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }
        public LoginViewModel Login
        {
            get
            {
                return ServiceLocator.Current.GetInstance<LoginViewModel>();
            }
        }
        public RegisterViewModel Register
        {
            get
            {
                return ServiceLocator.Current.GetInstance<RegisterViewModel>();
            }
        }
        public EditPasswordViewModel EditPassword
        {
            get
            {
                return ServiceLocator.Current.GetInstance<EditPasswordViewModel>();
            }
        }
        public MatchViewModel Match
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MatchViewModel>();
            }
        }
        public EditMatchViewModel EditMatch
        {
            get
            {
                return ServiceLocator.Current.GetInstance<EditMatchViewModel>();
            }
        }
        public RefereeViewModel Referee
        {
            get
            {
                return ServiceLocator.Current.GetInstance<RefereeViewModel>();
            }
        }

             public EditRefereeViewModel EditReferee
        {
            get
            {
                return ServiceLocator.Current.GetInstance<EditRefereeViewModel>();
            }
        }
        public PlayerViewModel Player

        {
            get
            {
                return ServiceLocator.Current.GetInstance<PlayerViewModel>();
            }
        }
        public RegistrationViewModel Registration

        {
            get
            {
                return ServiceLocator.Current.GetInstance<RegistrationViewModel>();
            }
        }
        public ClassViewModel _Class

        {
            get
            {
                return ServiceLocator.Current.GetInstance<ClassViewModel>();
            }
        }
        public PostViewModel Post

        {
            get
            {
                return ServiceLocator.Current.GetInstance<PostViewModel>();
            }
        }
         public PrizeTableViewModel Prize

        {
            get
            {
                return ServiceLocator.Current.GetInstance<PrizeTableViewModel>();
            }
        }
        public EditPViewModel EditP

        {
            get
            {
                return ServiceLocator.Current.GetInstance<EditPViewModel>();
            }
        }
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}