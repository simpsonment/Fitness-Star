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

namespace Fitness_Star
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   
    public partial class MainWindow : Window
    {
        //Μεταβλητή στην οποία θα έχουμε πρόσβαση σε ολόκληρη την εφαρμογή
        //Public και Static
        public static string Global_variable = "Global variable ";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }


    }
}
