using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Lab2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FadeInFadeOut : Page
    {
        public FadeInFadeOut()
        {
            this.InitializeComponent();
        }

        private void Ellipse_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            FadeOut.Begin();
        }

        private void Ellipse_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            FadeIn.Begin();
        }

        private void ver2_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Ver2_FadeIn.From = ver2.Opacity;
            FadeInVer2.Begin();
        }

        private void ver2_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            Ver2_FadeOut.From = ver2.Opacity;
            FadeOutVer2.Begin();
        }
    }
}
