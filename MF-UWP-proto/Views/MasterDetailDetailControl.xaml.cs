using System;
using System.Diagnostics;
using IO.Swagger.Model;
using MF_UWP_proto.Helpers;
using MF_UWP_proto.Models;
using MF_UWP_proto.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using MetroLog;

namespace MF_UWP_proto.Views
{
    public sealed partial class MasterDetailDetailControl : UserControl
    {
        private static readonly ILogger Log = LogManagerFactory.DefaultLogManager.GetLogger<MasterDetailDetailControl>();
        private MasterDetailViewModel ViewModel => DataContext as MasterDetailViewModel;

        public MediaSceneForListSchema MasterMenuItem
        {
            get => GetValue(MasterMenuItemProperty) as MediaSceneForListSchema;
            set => SetValue(MasterMenuItemProperty, value);
        }

        public static readonly DependencyProperty MasterMenuItemProperty = DependencyProperty.Register("MasterMenuItem", typeof(MediaSceneForListSchema), typeof(MasterDetailDetailControl), new PropertyMetadata(null, OnMasterMenuItemPropertyChanged));

        public MasterDetailDetailControl()
        {   
 
            InitializeComponent();
            Loaded += MasterDetailControlPage_Loaded;
        }
        private void MasterDetailControlPage_Loaded(object sender, RoutedEventArgs e)
        {
             RenderHelper.CurrentViewer= MediaViewer;
        }
        private static void OnMasterMenuItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
           Log.Info("I've been navigated to {0}",d);

            var control = d as MasterDetailDetailControl;
            control?.ForegroundElement.ChangeView(0, 0, 1);
        }

  
    }
}
