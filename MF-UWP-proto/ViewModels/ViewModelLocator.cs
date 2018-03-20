using System;

using GalaSoft.MvvmLight.Ioc;

using MF_UWP_proto.Services;
using MF_UWP_proto.Views;

using Microsoft.Practices.ServiceLocation;

namespace MF_UWP_proto.ViewModels
{
    /*The Locator VM contains the navigation routes for the application nad its context binding*/
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register(() => new NavigationServiceEx());
            Register<PivotViewModel, PivotPage>();
            Register<LandingPageViewModel, Landing_Page>();
            Register<LoginViewModel, Login>();
            Register<MainViewModel, MainPage>();
            Register<MasterDetailViewModel, MasterDetailPage>();
            Register<MediaPlayerViewModel, MediaPlayerPage>();
        }

        public LandingPageViewModel LandingPageViewModel => ServiceLocator.Current.GetInstance<LandingPageViewModel>();

        public LoginViewModel LoginViewModel => ServiceLocator.Current.GetInstance<LoginViewModel>();

        public MediaPlayerViewModel MediaPlayerViewModel => ServiceLocator.Current.GetInstance<MediaPlayerViewModel>();

        public MasterDetailViewModel MasterDetailViewModel => ServiceLocator.Current.GetInstance<MasterDetailViewModel>();

        public MainViewModel MainViewModel => ServiceLocator.Current.GetInstance<MainViewModel>();

        public PivotViewModel PivotViewModel => ServiceLocator.Current.GetInstance<PivotViewModel>();

        public NavigationServiceEx NavigationService => ServiceLocator.Current.GetInstance<NavigationServiceEx>();

        private void Register<TVm, TV>()
            where TVm : class
        {
            SimpleIoc.Default.Register<TVm>();

            NavigationService.Configure(typeof(TVm).FullName, typeof(TV));
        }
    }
}
