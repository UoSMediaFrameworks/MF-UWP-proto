using IO.Swagger.Model;
using MF_UWP_proto.ViewModels;
using MF_UWP_proto.Views;
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

namespace MF_UWP_proto.Models
{
    class MediaAssetObject : MediaAssetSchema
    {

        private static Panel currentViewer;

            
        private dynamic elementRef = null;

        public MediaAssetObject()
        {
        }
        public MediaAssetObject(MediaAssetSchema mo)
        {
            this = mo;
        }
        public static Panel CurrentViewer { get => currentViewer; set => currentViewer = value; }

        public async void RenderElement()
        {

           await Windows.ApplicationModel.Core.CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal,
() =>
{
  
    elementRef = GetRenderElementByType();
    elementRef.Margin = addRandomMargin(currentViewer);
    currentViewer.Children.Add(elementRef);
}
);


        }

        private dynamic GetRenderElementByType()
        {
            switch (this.Type)
            {
                case "text":
                    TextBlock newText = new TextBlock();
                    newText.Name = Id;
                    newText.Text = this.Text;
                    return newText;
                case "video":
                    MediaPlayerElement mediaPlayer = new MediaPlayerElement();
                    try
                    {
                        Uri pathUri = new Uri("ms-appx:///" + this.Url);
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
                    mediaPlayer.Name = Id;
                    mediaPlayer.AreTransportControlsEnabled = true;
                    return mediaPlayer;
                case "audio":
                    TextBlock newSound = new TextBlock();
                    newSound.Text = this.Id;
                    return newSound;
                case "image":
                    if (this.Url != null)
                    {
                        Image newImage = new Image();
                        BitmapImage bitmap = new BitmapImage();
                        newImage.CacheMode = new BitmapCache();

                        Uri tempValue;
                        if (Uri.TryCreate(this.Url, UriKind.RelativeOrAbsolute, out tempValue))
                        {

                        }
                        bitmap.UriSource = new Uri(this.Url, UriKind.RelativeOrAbsolute);
                        newImage.Name = Id;
                        newImage.Source = bitmap;
                        newImage.Height = 100;
                        newImage.Width = 200;
                        return newImage;
                    }
                    else
                    {
                        TextBlock newText2 = new TextBlock();
                        newText2.Name = Id;
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
            margin.Bottom = Convert.ToDouble(rnd.Next(1, (int)elementParent.RenderSize.Height / 3));
            margin.Left = Convert.ToDouble(rnd.Next(1, (int)elementParent.RenderSize.Width / 3));
            margin.Top = Convert.ToDouble(rnd.Next(1, (int)elementParent.RenderSize.Height / 3));
            margin.Right = Convert.ToDouble(rnd.Next(1, (int)elementParent.RenderSize.Width / 3));

            return margin;
        }
        public async void removeRenderedElement()
        {
           await Windows.ApplicationModel.Core.CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal,
            () =>
            {
               currentViewer.Children.Remove(elementRef);
            }
            );

        }
    }
}
