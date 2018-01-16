using IO.Swagger.Model;
using MF_UWP_proto.Models;
using MF_UWP_proto.Views;
using Newtonsoft.Json.Linq;
using Quobject.SocketIoClientDotNet.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MF_UWP_proto.Helpers
{
    class SocketHelper
    {
        private static Socket socket;
        private static SocketHelper instance;

        private SocketHelper() { }

        public static bool connected;

        public static SocketHelper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SocketHelper();
                }
                return instance;
            }
        }


        public static void ConnectToWS(string password = null)
        {

            socket = Quobject.SocketIoClientDotNet.Client.IO.Socket(Constants.apiURL);         // I Need a better way of doing the code below
            //object creds = password == null ? new Token(SessionHelper.sessionResult.Token) : new Password(password);
            JObject json;
            if (password != null)
            {
                json = JObject.FromObject(new Password(password));
            }
            else
            {
                json = JObject.FromObject(new Token(SessionHelper.sessionResult.Token));
            }

            socket.On(Socket.EVENT_CONNECT, () =>
            {
                socket.Emit("auth", (err, token, sockedId, groupId) =>
                {
                    if (err != null)
                    {
                        Debug.WriteLine("Web socket authentication error: " + err.ToString());
                       // MainPage.Current.NotifyUser("Web socket authentication error: " + err.ToString(), MainPage.NotifyType.ErrorMessage);
                        socket.Disconnect();
                    }
                    else
                    {
                        connected = true;
                        socket.Emit("register", SessionHelper.sessionResult.RoomId);
                        Debug.WriteLine("No errors for websocket " + token);
                    }

                }, json);


            });
            socket.On(Socket.EVENT_CONNECT_ERROR, (data) =>
            {
                Debug.WriteLine("EVENT_CONNECT_ERROR:" + data);
            });

            socket.On("event.playback.media.show", (data) =>
            {

                try
                {
                    var obj = JObject.FromObject(data);
                    IDictionary<string, JToken> dictionary = obj;
                    if (dictionary.ContainsKey("value"))
                    {
                        var test = obj["value"];
                        var hello = test.ToObject<MediaAssetObject>();

                        hello.RenderElement();

                        // hello.removeRenderedElement();

                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }


                //MainPage.randomV
            });

            socket.On("event.playback.media.transition", (data) =>
            {
                Debug.WriteLine(".media.transition " + data);
                //try
                //{
                //    var obj = JObject.FromObject(data);
                //    IDictionary<string, JToken> dictionary = obj;
                //    if (dictionary.ContainsKey("value"))
                //    {
                //        var test = obj["value"];
                //        var hello = test.ToObject<MediaAssetObject>();
                //        hello.TransitionElement();
                //    }
                //}
                //catch (Exception ex)
                //{
                //    Debug.WriteLine(ex);
                //}
            });
            socket.On("event.playback.media.done", (data) =>
            {
                //MainPage.randomVP
                Debug.WriteLine(".media.done " + data);
                try
                {
                    var obj = JObject.FromObject(data);
                    IDictionary<string, JToken> dictionary = obj;
                    if (dictionary.ContainsKey("value"))
                    {
                        var test = obj["value"];
                        var hello = test.ToObject<MediaAssetObject>();
                        hello.removeRenderedElement();
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            });
        }

        public static void RegisterToRoom(string roomId)
        {
            socket.Emit("register", roomId);
        }
    }
}
