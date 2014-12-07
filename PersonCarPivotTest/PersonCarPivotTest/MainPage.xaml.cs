using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Data.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Imaging;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// Szablon elementu Pusta strona jest udokumentowany na stronie http://go.microsoft.com/fwlink/?LinkId=391641

namespace PersonCarPivotTest
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie, lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
            
        }

        /// <summary>
        /// Wywoływane, gdy ta strona ma być wyświetlona w ramce.
        /// </summary>
        /// <param name="e">Dane zdarzenia, opisujące, jak została osiągnięta ta strona.
        /// Ten parametr jest zazwyczaj używany do konfigurowania strony.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Tutaj przygotuj stronę do wyświetlenia.

            // TODO: Jeśli aplikacja zawiera wiele stron, upewnij się, że jest
            // obsługiwany przycisk Wstecz sprzętu, rejestrując
            // zdarzenie Windows.Phone.UI.Input.HardwareButtons.BackPressed.
            // Jeśli używasz obiektu NavigationHelper dostarczanego w niektórych szablonach,
            // to zdarzenie jest już obsługiwane.
        }

        private void ButtonAdd_OnClick(object sender, RoutedEventArgs e)
        {
            listView.Items.Add(new Person(textBoxName.Text, Convert.ToInt32(textBoxAge.Text), new Car(textBoxModel.Text, Convert.ToInt32(textBoxYear.Text))));

            textBoxName.Text = "";
            textBoxAge.Text = "";
            textBoxModel.Text = "";
            textBoxYear.Text = "";
        }

        private void AddImage_OnClick(object sender, RoutedEventArgs e)
        {
            myImage.Source =
                new BitmapImage(
                    new Uri(
                        @"http://wallpicshd.com/wp-content/uploads/2014/03/gta-v-logo-picture-image-wallpaper-android.jpg",
                        UriKind.RelativeOrAbsolute));
        }
    }
}
