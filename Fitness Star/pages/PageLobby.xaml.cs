using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fitness_Star.pages
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class PageLobby : Page
    {
        public PageLobby()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PageTreadmill treadmill = new PageTreadmill();
            this.NavigationService.Navigate(treadmill);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PagePool pool = new PagePool();
            this.NavigationService.Navigate(pool);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PageCafeteria cafeteria = new PageCafeteria();
            this.NavigationService.Navigate(cafeteria);
        }

        bool clicked = false;
        
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var imageDirPath = String.Format(@"C:\Users\EXPERT\Documents\Visual Studio 2013\Projects\Fitness Star\Fitness Star\bin\Debug\Images\");
            if (clicked)
                this.Background = new ImageBrush(new BitmapImage(new Uri(imageDirPath + "lobby.jpg")));
            else
                this.Background = new ImageBrush(new BitmapImage(new Uri(imageDirPath + "lobby1.jpg")));
            clicked = !clicked;
        }

    }
}
