using IO.Swagger.Model;
using MF_UWP_proto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Core;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
/*This helper will handle all calls related to adding maintaining and removing media objects on the app*/
namespace MF_UWP_proto.Helpers
{
    class Renderer
    {

        private static Renderer Instance;

        public static Renderer instance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new Renderer();
                }
                return Instance;
            }
        }
        private static Panel currentViewer;

        private dynamic elementRef = null;

        public static Panel CurrentViewer { get => currentViewer; set => currentViewer = value; }

        public async void RenderElement(MediaAssetObject mao)
        {
            await Windows.ApplicationModel.Core.CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal,
            () =>
            { 
                elementRef = GetRenderElementByType(mao);
                elementRef.Margin = addRandomMargin(currentViewer);
                if (currentViewer != null)
                {
                    currentViewer.Children.Add(elementRef);
                }
                
            });
        }
        public async void RenderElement(MediaAssetSchema mas)
        {
            await Windows.ApplicationModel.Core.CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal,
            () =>
            {
                elementRef = GetRenderElementByType(mas);
                elementRef.Margin = addRandomMargin(currentViewer);
                if (currentViewer != null)
                {
                    currentViewer.Children.Add(elementRef);
                }
            });
        }

        private dynamic GetRenderElementByType(MediaAssetSchema mao)
        {
            switch (mao.Type)
            {
                case "text":
                    TextBlock newText = new TextBlock();
                    newText.Name = mao.Id;
                    newText.Text = mao.Text;
                    return newText;
                case "video":
                    MediaPlayerElement mediaPlayer = new MediaPlayerElement();
                    try
                    {
                        Uri pathUri = new Uri("ms-appx:///" + mao.Url);
                        mediaPlayer.Source = MediaSource.CreateFromUri(pathUri);
                    }
                    catch (Exception ex)
                    {
                        if (ex is FormatException)
                        {
                            // handle exception.
                            // For example: Log error or notify user problem with file
                        }
                    }
                    mediaPlayer.AutoPlay = true;
                    mediaPlayer.Name = mao.Id;
                    mediaPlayer.AreTransportControlsEnabled = true;
                    return mediaPlayer;
                case "audio":
                    TextBlock newSound = new TextBlock();
                    newSound.Text = mao.Id;
                    return newSound;
                case "image":
                    if (mao.Url != null)
                    {
                        Image newImage = new Image();
                        BitmapImage bitmap = new BitmapImage();
                        newImage.CacheMode = new BitmapCache();

                        Uri tempValue;
                        if (Uri.TryCreate(mao.Url, UriKind.RelativeOrAbsolute, out tempValue))
                        {
                        }
                        bitmap.UriSource = new Uri(mao.Url, UriKind.RelativeOrAbsolute);
                        newImage.Name = mao.Id;
                        newImage.Source = bitmap;
                        newImage.Height = 100;
                        newImage.Width = 200;
                        return newImage;
                    }
                    else
                    {
                        TextBlock newText2 = new TextBlock();
                        newText2.Name = mao.Id;
                        newText2.Text = "Aaron is a troll";
                        return newText2;
                    }
                default: throw new ArgumentOutOfRangeException();
            }
        }
        private Thickness addRandomMargin(dynamic elementParent)
        {
            Random rnd = new Random();
            Thickness margin = new Thickness();
            margin.Bottom = Convert.ToDouble(rnd.Next(0, (int)elementParent.RenderSize.Height / 3));
            margin.Left = Convert.ToDouble(rnd.Next(0, (int)elementParent.RenderSize.Width / 3));
            margin.Top = Convert.ToDouble(rnd.Next(0, (int)elementParent.RenderSize.Height / 3));
            margin.Right = Convert.ToDouble(rnd.Next(0, (int)elementParent.RenderSize.Width / 3));

            return margin;
        }
        public async void removeRenderedElement()
        {
            await Windows.ApplicationModel.Core.CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal,
             () =>{
                 if (currentViewer != null)
                 {
                     currentViewer.Children.Remove(elementRef);
                 }
               
             });
        }
    }
}
