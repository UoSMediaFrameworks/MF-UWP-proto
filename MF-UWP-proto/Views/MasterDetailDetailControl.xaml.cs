using System;
using IO.Swagger.Model;
using MF_UWP_proto.Models;
using MF_UWP_proto.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MF_UWP_proto.Views
{
    public sealed partial class MasterDetailDetailControl : UserControl
    {
        private MasterDetailViewModel ViewModel
        {
            get { return DataContext as MasterDetailViewModel; }
        }
        public MediaSceneForListSchema MasterMenuItem
        {
            get { return GetValue(MasterMenuItemProperty) as MediaSceneForListSchema; }
            set { SetValue(MasterMenuItemProperty, value); }
        }

        public static readonly DependencyProperty MasterMenuItemProperty = DependencyProperty.Register("MasterMenuItem", typeof(MediaSceneForListSchema), typeof(MasterDetailDetailControl), new PropertyMetadata(null, OnMasterMenuItemPropertyChanged));

        public MasterDetailDetailControl()
        {   
 
            InitializeComponent();
            Loaded += MasterDetailControlPage_Loaded;
        }
        private void MasterDetailControlPage_Loaded(object sender, RoutedEventArgs e)
        {
             ViewModel.MediaGrid = MediaViewer;
        }
        private static void OnMasterMenuItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as MasterDetailDetailControl;
            control.ForegroundElement.ChangeView(0, 0, 1);
        }

  
    }
}
