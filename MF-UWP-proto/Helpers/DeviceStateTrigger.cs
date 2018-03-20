using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
/* This calss has been added to be used for device based changes to the app*/
namespace MF_UWP_proto.Helpers
{
    class DeviceStateTrigger: StateTriggerBase
    {
        private string _deviceFamily;
        private Boolean _isLoggedIn;

        public Boolean IsLoggedIn
        {
            get => _isLoggedIn;
            set
            {
                _isLoggedIn = value;
                SetActive(true);
            }
        }

        public string DeviceFamily
        {
            get => _deviceFamily;
            set
            {
                _deviceFamily = value;
                SetActive(_deviceFamily == Windows.System.Profile.AnalyticsInfo.VersionInfo.DeviceFamily);

            }
        }
    }
}
