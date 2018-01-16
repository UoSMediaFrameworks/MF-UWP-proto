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

namespace MF_UWP_proto.Helpers
{
    class SessionHelper
    {

        private static SessionHelper instance;

        private SessionHelper() { }

        private const string REST_SESSION_FILE_NAME = "RESTsession.txt";
        private static string _RestSessionPath = Path.Combine(ApplicationData.Current.LocalFolder.Path, REST_SESSION_FILE_NAME);

        public static SessionResult sessionResult = new SessionResult();


        public static SessionHelper Instance
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
            sessionResult = session;
            Debug.WriteLine("Update session data:" + sessionResult.ToString());
            SaveSessionAsync();
        }
        public static void ClearSession()
        {
            sessionResult = new SessionResult();
            SaveSessionAsync();
        }
        private static async void SaveSessionAsync()
        {


            string sessionToJson = SerializeSessionToJSON();

            if (File.Exists(_RestSessionPath))
            {
                StorageFile sessionFile = await StorageFile.GetFileFromPathAsync(_RestSessionPath);
                await FileIO.WriteTextAsync(sessionFile, sessionToJson);
            }
            else
            {
                StorageFile sessionFile = await ApplicationData.Current.LocalFolder.CreateFileAsync(REST_SESSION_FILE_NAME);
                await FileIO.WriteTextAsync(sessionFile, sessionToJson);
            }
        }

        /// <summary>
        /// Gets the useraccount list file and deserializes it from JSON to a list of useraccount objects.
        /// </summary>
        /// <returns>List of useraccount objects</returns>
        public static async Task<SessionResult> LoadSessionAsync()
        {
            try
            {
                if (File.Exists(_RestSessionPath))
                {
                    StorageFile sessionFile = await StorageFile.GetFileFromPathAsync(_RestSessionPath);
                    string sessionJSON = await FileIO.ReadTextAsync(sessionFile);
                    DeserializeJSONToSession(sessionJSON);
                    Debug.WriteLine("Session load fromn ls " + sessionResult);
                    Configuration.Default.AddApiKey("X-API-Key", sessionResult.Token);
                }

                return sessionResult;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Err " + ex);
                return sessionResult;
            }



        }

        /// <summary>
        /// Uses the local list of accounts and returns an XML formatted string representing the list
        /// </summary>
        /// <returns>XML formatted list of accounts</returns>
        public static string SerializeSessionToJSON()
        {
            var writer = "";
            writer = JsonConvert.SerializeObject(sessionResult);

            return writer.ToString();
        }

        /// <summary>
        /// Takes an XML formatted string representing a list of accounts and returns a list object of accounts
        /// </summary>
        /// <param name="listAsXml">XML formatted list of accounts</param>
        /// <returns>List object of accounts</returns>
        public static SessionResult DeserializeJSONToSession(string sessionAsJSON)
        {

            return sessionResult = JsonConvert.DeserializeObject<SessionResult>(sessionAsJSON);
        }
    }
}
