using IO.Swagger.Model;
using System;
using System.Threading.Tasks;
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


        private dynamic _elementRef = null;
        private static RenderHelper _instance;

        private RenderHelper()
        {
        }

        public static RenderHelper Instance => _instance ?? (_instance = new RenderHelper());

        public dynamic RenderElement(MediaAssetSchema asset)
        {
            _elementRef = GetRenderElementByType(asset);
          
            return _elementRef;
        }

        public static dynamic GetRenderElementByType(MediaAssetSchema asset)
        {
            switch (asset.Type)
            {
                case "text":
                    TextBlock newText = new TextBlock
                    {
                        Name = asset.Id,
                        Text = asset.Text
                    };
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
                    TextBlock newSound = new TextBlock
                    {
                        Text = asset.Id
                    };
                    return newSound;
                case "image":
                    if (asset.Url != null)
                    {
                        var newImage = new Image();
                        var bitmap = new BitmapImage();
                        newImage.CacheMode = new BitmapCache();

                        if (Uri.TryCreate(asset.Url, UriKind.RelativeOrAbsolute, out var tempValue))
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
                        var newText2 = new TextBlock
                        {
                            Name = asset.Id,
                            Text = "Aaron is a troll"
                        };
                        return newText2;
                    }
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static Thickness AddRandomMargin(dynamic elementParent)
        {
            var rnd = new Random();
            var margin = new Thickness
            {
                Bottom = Convert.ToDouble(rnd.Next(0, (int) elementParent.RenderSize.Height / 3)),
                Left = Convert.ToDouble(rnd.Next(0, (int) elementParent.RenderSize.Width / 3)),
                Top = Convert.ToDouble(rnd.Next(0, (int) elementParent.RenderSize.Height / 3)),
                Right = Convert.ToDouble(rnd.Next(0, (int) elementParent.RenderSize.Width / 3))
            };

            return margin;
        }
    }
}
