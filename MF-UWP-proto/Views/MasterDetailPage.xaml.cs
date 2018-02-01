using System;
using System.Collections.Generic;
using System.Diagnostics;
using IO.Swagger.Model;
using MF_UWP_proto.Helpers;
using MF_UWP_proto.Models;
using MF_UWP_proto.ViewModels;
using Microsoft.Toolkit.Uwp.UI.Controls;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MF_UWP_proto.Views
{
    public sealed partial class MasterDetailPage : Page
    {
        private MasterDetailViewModel ViewModel
        {
            get { return DataContext as MasterDetailViewModel; }
        }

        public MasterDetailPage()
        {
            InitializeComponent();
            Loaded += MasterDetailPage_Loaded;
        }

        private async void MasterDetailPage_Loaded(object sender, RoutedEventArgs e)
        {
            //load date if list exists
            await ViewModel.LoadDataAsync(MasterDetailsViewControl.ViewState);
        }
        private async void getScenebyId(MediaSceneForListSchema selectedItem)
        {
            MediaSceneSchema scene;
            try
            {
                //var task = MainPage.DefaultAPI.SceneFullGetAsync(selectedItem.Id);
                var task = ViewModel.api.SceneFullGetAsync(selectedItem.Id);

                scene = await task;
                List<MediaAssetSchema> mediaAssetList = scene.Scene;

                //Debug.WriteLine("SceneFullGetAsync successfull+ " + scene);
                //WriteToConsole(mediaAssetList);
                foreach (MediaAssetSchema o in mediaAssetList)
                {
                   // showMediaObjectWS(o);
                    showMediaObjectClientSided(o);
                }


            }
            catch (Exception ex)
            {
                Debug.WriteLine("SceneFullGetAsync has failed" + ex.Message);
            }

        }
        public void showMediaObjectClientSided(MediaAssetSchema mo)
        {
            MediaAssetObject mao = new MediaAssetObject(mo);
            mao.RenderElement();
            
        }
        public async void showMediaObjectWS(MediaAssetSchema mo)
        {
            MediaCommand mc = new MediaCommand(SessionHelper.sessionResult.RoomId, mo);

            try
            {
                var x = await ViewModel.api.PlaybackMediaShowPostAsync(mc);

            }
            catch (Exception ex)
            {
                Debug.WriteLine("showMedia err " + ex.Message);
            }

        }
        private void MasterDetailsViewControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = ((sender as MasterDetailsView).SelectedItem as MediaSceneForListSchema);
            while (ViewModel.MediaGrid.Children.Count > 0)
            {
                ViewModel.MediaGrid.Children.RemoveAt(0);
            }
            getScenebyId(selected);
        }
    }
}
