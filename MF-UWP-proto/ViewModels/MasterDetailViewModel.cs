using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using GalaSoft.MvvmLight;
using IO.Swagger.Api;
using IO.Swagger.Model;
using MF_UWP_proto.Models;
using MF_UWP_proto.Services;

using Microsoft.Toolkit.Uwp.UI.Controls;
using Windows.UI.Xaml.Controls;

namespace MF_UWP_proto.ViewModels
{
    public class MasterDetailViewModel : ViewModelBase
    {
        private MediaSceneForListSchema _selected;
        public DefaultApi api;

        public MediaSceneForListSchema Selected
        {
            get { return _selected; }
            set { Set(ref _selected, value); }
        }

        public ObservableCollection<MediaSceneForListSchema> SampleItems { get; private set; } = new ObservableCollection<MediaSceneForListSchema>();
        public Grid MediaGrid;
        public MasterDetailViewModel()
        {
            api = new DefaultApi();
            MediaAssetObject.CurrentViewer = MediaGrid;
        }

        public async Task LoadDataAsync(MasterDetailsViewState viewState)
        {
            SampleItems.Clear();
            //This is where the subset of data is loaded
                SceneList data = await api.SceneListGetAsync();


            foreach (var item in data)
            {
                SampleItems.Add(item);
            }

            if (viewState == MasterDetailsViewState.Both)
            {
                Selected = SampleItems.First();
            }
        }
    }
}
