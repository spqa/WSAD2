using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MediaElement
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class VideoPlayer : Page
    {
        public VideoPlayer()
        {
            this.InitializeComponent();
        }

        private async void find_Click(object sender, RoutedEventArgs e)
        {
            FileOpenPicker open = new FileOpenPicker();
            open.FileTypeFilter.Add(".mp4");
            open.SuggestedStartLocation = PickerLocationId.VideosLibrary;
            open.ViewMode = PickerViewMode.Thumbnail;
            var file = await open.PickSingleFileAsync();
            var Stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            videoElement.SetSource(Stream,file.ContentType);
        }

        private void play_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
