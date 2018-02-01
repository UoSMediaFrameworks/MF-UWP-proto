using System;
using IO.Swagger.Api;
using MF_UWP_proto.Helpers;
using MF_UWP_proto.ViewModels;

using Windows.UI.Xaml.Controls;

namespace MF_UWP_proto.Views
{
    public sealed partial class MainPage : Page
    {



        private MainViewModel ViewModel
        {
            get { return DataContext as MainViewModel; }
        }
        public MainPage()
        {   
            SessionHelper.LoadSessionAsync();
            InitializeComponent();
        }

     
    }
}
