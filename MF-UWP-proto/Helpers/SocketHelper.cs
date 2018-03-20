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
using MF_UWP_proto.Helpers;

/*The socket helper class, is designed to contain web socket related functions
 and to maintain the instance of the Socket class running to receive messages.*/
namespace MF_UWP_proto.Helpers
{
    class SocketHelper
    {
        private static Socket _socket;
        private static SocketHelper _instance;

        private SocketHelper() { }

        public static bool Connected;

        public  SocketHelper Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SocketHelper();
                }
                return _instance;
            }
        }

     

        public static void ConnectToWs(string password = null)
        {

            _socket = Quobject.SocketIoClientDotNet.Client.IO.Socket(Constants.apiURL);         // I Need a better way of doing the code below
            //object creds = password == null ? new Token(SessionHelper.sessionResult.Token) : new Password(password);
            JObject json;
            if (password != null)
            {
                json = JObject.FromObject(new Password(password));
            }
            else
            {
                json = JObject.FromObject(new Token(SessionHelper.SessionResult.Value.Token));
            }

            _socket.On(Socket.EVENT_CONNECT, () =>
            {
                _socket.Emit("auth", (err, token, sockedId, groupId) =>
                {
                    if (err != null)
                    {
                        Debug.WriteLine("Web socket authentication error: " + err.ToString());
                       // MainPage.Current.NotifyUser("Web socket authentication error: " + err.ToString(), MainPage.NotifyType.ErrorMessage);
                        _socket.Disconnect();
                    }
                    else
                    {
                        Connected = true;
                        _socket.Emit("register", (err2, data) =>
                        {
                            Debug.WriteLine("err2",err2);
                            Debug.WriteLine("data",data);
                        }, "twitter");
                        Debug.WriteLine("No errors for websocket " + token);
                    }

                }, json);


            });
            _socket.On(Socket.EVENT_CONNECT_ERROR, (data) =>
            {
                Debug.WriteLine("EVENT_CONNECT_ERROR:" + data);
            });

            _socket.On("event.playback.media.show", (data) =>
            {

                try
                {
                    var obj = JObject.FromObject(data);
                    IDictionary<string, JToken> dictionary = obj;
                    if (dictionary.ContainsKey("value"))
                    {
                        var objValue = obj["value"];
                        var hello = objValue.ToObject<MediaAssetSchema>();
                        Debug.WriteLine(objValue);
                        RenderHelper.Instance.RenderElement(hello);
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }


                //MainPage.randomV
            });

            _socket.On("event.playback.media.transition", (data) =>
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
            _socket.On("event.playback.media.done", (data) =>
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
                        var hello = test.ToObject<MediaAssetSchema>();
                        RenderHelper.Instance.RenderElement(hello);
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
            _socket.Emit("register",(err, data) =>
            {
                Debug.WriteLine(err);
                Debug.WriteLine(data);
            }, roomId);
        }
    }
}
