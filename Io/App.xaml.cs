using System.Windows;
using System.Windows.Media;
using FirstFloor.ModernUI.Presentation;

namespace Io
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void this_Startup(object sender, StartupEventArgs e)
        {
            // set up MUI theme
            Color ioAccentColor = (Color)App.Current.FindResource("IoAccentColor");
            AppearanceManager.Current.AccentColor = ioAccentColor;
        }
    }
}
