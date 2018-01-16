using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

using GalaSoft.MvvmLight;

using MF_UWP_proto.Models;
using MF_UWP_proto.Services;

using Microsoft.Toolkit.Uwp.UI.Controls;

namespace MF_UWP_proto.ViewModels
{
    public class MasterDetailViewModel : ViewModelBase
    {
        private SampleOrder _selected;

        public SampleOrder Selected
        {
            get { return _selected; }
            set { Set(ref _selected, value); }
        }

        public ObservableCollection<SampleOrder> SampleItems { get; private set; } = new ObservableCollection<SampleOrder>();

        public MasterDetailViewModel()
        {
        }

        public async Task LoadDataAsync(MasterDetailsViewState viewState)
        {
            SampleItems.Clear();
            //This is where the subset of data is loaded
            var data = await SampleDataService.GetSampleModelDataAsync();

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
