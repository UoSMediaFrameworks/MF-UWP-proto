using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using MF_UWP_proto.Helpers;

namespace MF_UWP_proto.ViewModels
{
    public class LandingPageViewModel:ViewModelBase, INotifyPropertyChanged
    {


        public LandingPageViewModel()
        {
            PropertyChanged += Test_Changed;

        }
        public async System.Threading.Tasks.Task AutcheticateWithWSAsync()
        {
            Configuration.Default.Timeout = new TimeSpan(0, 1, 0);

            var creds = new Password("kittens"); // Password | A password key

            try
            {
                System.Threading.Tasks.Task<SessionResult> task = new DefaultApi().AuthTokenGetPostAsync(creds);
                SessionResult result = await task;
                // Upadting session and Api Key for future api calls until session needs to be renewed
                SessionHelper.UpdateSession(result);
                SocketHelper.ConnectToWs();
                Configuration.Default.AddApiKey("X-API-Key", result.Token);
                

            }
            catch (Exception eerr)
            {

                Debug.WriteLine("Exception when calling DefaultApi.AuthTokenGetPost: " + eerr.Message);
            }

        }

        void Test_Changed(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "SomeProperty":
                    // Do something
                    break;
            }
        }
    }
}
