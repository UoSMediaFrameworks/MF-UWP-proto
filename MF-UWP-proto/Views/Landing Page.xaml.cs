using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using MF_UWP_proto.Helpers;
using MF_UWP_proto.ViewModels;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238
/*The landing page, will function as the base page users arrive at upon login. It will contain some basic useful information
 about the state of the app and its abilities in order to help guide new users.*/
namespace MF_UWP_proto.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Landing_Page : Page
    {
        private LandingPageViewModel ViewModel => DataContext as LandingPageViewModel;

        public Landing_Page()
        {
            this.InitializeComponent();
            Loaded += Landing_Page_Loaded;
            InformationForNewUser.Text =
                "This a temporary skip of the login process at the moment, it is happening automatically in the background" +
                "Please wait for the session information to show up here";
            
        }

        private async void Landing_Page_Loaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.AutcheticateWithWSAsync();
       
        }

        private void RoomIdBtn_OnClick(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(RoomIdBox.Text))
            {
                ErrorBox.Text = "Please enter a Room ID";
            }
            else
            {
                SessionResult temp = SessionHelper.SessionResult.Value;
                temp.RoomId = RoomIdBox.Text;

                SessionHelper.UpdateSession(temp);
            }
              
           
        }
    }
}
