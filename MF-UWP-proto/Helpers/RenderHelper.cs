using IO.Swagger.Model;
using System;
using Windows.Media.Core;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using MF_UWP_proto.Helpers;

namespace MF_UWP_proto.Helpers
{
    class RenderHelper
    {

        /*
         * This class is made to help with rendering media elements to an active parent element.
         * A viewer needs to be set at the application level, which will be the instance that 
         */

        private static Panel currentViewer;

        
        private dynamic _elementRef = null;
        private static RenderHelper instance;
        public static Panel CurrentViewer
        {
            get => currentViewer;
            set => currentViewer = value;
        }
        private RenderHelper() { }
        public static RenderHelper Instance => instance ?? (instance = new RenderHelper());

        public async void RenderElement(MediaAssetSchema asset)
        {
            if(currentViewer != null)
            {

            await Windows.ApplicationModel.Core.CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal,
             () => {

                 _elementRef = GetRenderElementByType(asset);
                 _elementRef.Margin = addRandomMargin(currentViewer);
                 currentViewer.Children.Add(_elementRef);
             }
            );

            }

        }

        private dynamic GetRenderElementByType(MediaAssetSchema asset)
        {
            switch (asset.Type)
            {
                case "text":
                    TextBlock newText = new TextBlock();
                    newText.Name = asset.Id;
                    newText.Text = asset.Text;
                    return newText;
                case "video":
                    MediaPlayerElement mediaPlayer = new MediaPlayerElement();
                    try
                    {
                        Uri pathUri = new Uri("ms-appx:///" + asset.Url);
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
                    mediaPlayer.Name = asset.Id;
                    mediaPlayer.AreTransportControlsEnabled = true;
                    return mediaPlayer;
                case "audio":
                    TextBlock newSound = new TextBlock();
                    newSound.Text = asset.Id;
                    return newSound;
                case "image":
                    if (asset.Url != null)
                    {
                        Image newImage = new Image();
                        BitmapImage bitmap = new BitmapImage();
                        newImage.CacheMode = new BitmapCache();

                        Uri tempValue;
                        if (Uri.TryCreate(asset.Url, UriKind.RelativeOrAbsolute, out tempValue))
                        {

                        }
                        bitmap.UriSource = new Uri(asset.Url, UriKind.RelativeOrAbsolute);
                        newImage.Name = asset.Id;
                        newImage.Source = bitmap;
                        newImage.Height = 100;
                        newImage.Width = 200;
                        return newImage;
                    }
                    else
                    {
                        TextBlock newText2 = new TextBlock();
                        newText2.Name = asset.Id;
                        newText2.Text = "Aaron is a troll";
                        return newText2;
                    }
                default:
                    throw new ArgumentOutOfRangeException();


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
             () => {
                 currentViewer.Children.Remove(_elementRef);
             }
            );

        }
    }
}
