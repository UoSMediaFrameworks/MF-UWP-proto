using System;
using IO.Swagger.Api;
using MF_UWP_proto.Helpers;
using MF_UWP_proto.ViewModels;

using Windows.UI.Xaml.Controls;

namespace MF_UWP_proto.Views
{
    public sealed partial class MainPage : Page
    {


        public static MainPage Current;
        public static DefaultApi DefaultAPI;
        public static dynamic randomVP;
        private MainViewModel ViewModel
        {
            get { return DataContext as MainViewModel; }
        }

        public MainPage()
        {
            Current = this;
            SessionHelper.LoadSessionAsync();
            DefaultAPI = new DefaultApi();
            InitializeComponent();
        }
    }
}
