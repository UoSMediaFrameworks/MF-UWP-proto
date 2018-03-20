using IO.Swagger.Client;
using IO.Swagger.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
/*The session helper class is meant to maintain and modify the session credential
 For Media Frameworks*/
namespace MF_UWP_proto.Helpers
{
    class SessionHelper
    {

        private  SessionHelper instance;
       
        private SessionHelper() { }

        public static ObservableProp<SessionResult> SessionResult { get; set; }
            = new ObservableProp<SessionResult>();


        public  SessionHelper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SessionHelper();
                }
                return instance;
            }
        }


        public static void UpdateSession(SessionResult session)
        {
            SessionResult.Value = session;
            Debug.WriteLine("Update session data:" + SessionResult.Value.ToString());
    
        }

        public  void ClearSession()
        {
            SessionResult.Value = new SessionResult();
        }

    }
}
