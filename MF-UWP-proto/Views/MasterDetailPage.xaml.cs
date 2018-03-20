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
        private MasterDetailViewModel ViewModel => DataContext as MasterDetailViewModel;

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
        

        private static void ShowMediaObjectClientSided(MediaAssetSchema mo)
        {
            RenderHelper.Instance.RenderElement(mo);          
        }
        public async void ShowMediaObjectWs(MediaAssetSchema mo)
        {
            MediaCommand mc = new MediaCommand(SessionHelper.SessionResult.Value.RoomId, mo);

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
            var selected = ((sender as MasterDetailsView)?.SelectedItem as MediaSceneForListSchema);
          
           ViewModel.GetScenebyId(selected);
        }
    }
}
