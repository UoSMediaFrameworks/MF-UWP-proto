using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using IO.Swagger.Api;
using IO.Swagger.Model;
using MF_UWP_proto.Helpers;
using MF_UWP_proto.Models;
using MF_UWP_proto.Services;
using Microsoft.Toolkit.Uwp.UI.Controls;
using Windows.UI.Xaml.Controls;
using MetroLog;
using MF_UWP_proto.Views;

namespace MF_UWP_proto.ViewModels
{
    public class MasterDetailViewModel : ViewModelBase
    {
        private static readonly ILogger Log = LogManagerFactory.DefaultLogManager.GetLogger<MasterDetailViewModel>();
        private MediaSceneForListSchema _selected;
        public readonly DefaultApi api;
        public MediaSceneSchema Scene;

        public MediaSceneForListSchema Selected
        {
            get => _selected;
            set => Set(ref _selected, value);
        }

        public ObservableCollection<MediaSceneForListSchema> SampleItems { get; private set; } =
            new ObservableCollection<MediaSceneForListSchema>();

        public MasterDetailViewModel()
        {
            api = new DefaultApi();
        }

        public async Task LoadDataAsync(MasterDetailsViewState viewState)
        {
            //RenderHelper.CurrentViewer = MediaGrid;
            SampleItems.Clear();
            //This is where the subset of data is loaded
            var data = await api.SceneListGetAsync();

            Log.Info("list {0}", data);
            foreach (var item in data)
            {
                SampleItems.Add(item);
            }
        }

        public async void GetScenebyId(MediaSceneForListSchema selectedItem)
        {
            try
            {
                //var task = MainPage.DefaultAPI.SceneFullGetAsync(selectedItem.Id);
                var task = api.SceneFullGetAsync(selectedItem.Id);

                var scene = await task;
              
            }
            catch (Exception ex)
            {
                Debug.WriteLine("SceneFullGetAsync has failed" + ex.Message);
            }
        }
    }
}
