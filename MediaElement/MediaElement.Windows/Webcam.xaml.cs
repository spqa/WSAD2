using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Capture;
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
    public sealed partial class Webcam : Page
    {
        

        public Webcam()
        {
            this.InitializeComponent();
            
            
        }

        private async void Loaded(object sender, RoutedEventArgs e)
        {
            MediaCapture capMana = new MediaCapture();
            await capMana.InitializeAsync();
            Webcam_Logitech.Source = capMana;
            await capMana.StartPreviewAsync();
        }
    }
}
