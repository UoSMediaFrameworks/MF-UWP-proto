using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using MF_UWP_proto.Helpers;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MF_UWP_proto.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Login : Page
    {
        private object rootPage;

        private Login ViewModel
        {
            get { return DataContext as Login; }
        }
        

        public Login()
        {
            this.InitializeComponent();
        }
        private void PassportSignInButton_Click(object sender, RoutedEventArgs e)
        {
            AutcheticateWithWSAsync(UsernameTextBox.Text);
            ErrorMessage.Text = "";
        }
        private async System.Threading.Tasks.Task AutcheticateWithWSAsync(string password)
        {
            Configuration.Default.Timeout = new TimeSpan(0, 1, 0);

            var creds = new Password(password); // Password | A password key

            try
            {
                System.Threading.Tasks.Task<SessionResult> task = new DefaultApi().AuthTokenGetPostAsync(creds);
                SessionResult result = await task;
                // Upadting session and Api Key for future api calls until session needs to be renewed
                SessionHelper.UpdateSession(result);
                SocketHelper.ConnectToWS();
                Configuration.Default.AddApiKey("X-API-Key", result.Token);
                // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
                // Configuration.Default.ApiKeyPrefix.Add("X-API-Key", "Bearer");
               
            }
            catch (Exception eerr)
            {

                Debug.WriteLine("Exception when calling DefaultApi.AuthTokenGetPost: " + eerr.Message);
            }

        }
    }
}
