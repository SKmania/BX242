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
using mshtml;

namespace BX24
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            iconclosed.Visibility = Visibility.Collapsed;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        int we = 0;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
                        
            if (we == 0)
            {
                this.WindowState = WindowState.Maximized;
                we = we + 1;
                iconopen.Visibility = Visibility.Collapsed;
                iconclosed.Visibility = Visibility.Visible;
            }
            else if (we == 1)
            {
                this.WindowState = WindowState.Normal;
                we = we - 1;
                iconopen.Visibility = Visibility.Visible;
                iconclosed.Visibility = Visibility.Collapsed;
            }
            else { }



        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            telecom telecom = new telecom();
            frame1.Navigate(telecom);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Tarif tarif = new Tarif();
            frame1.Navigate(tarif);
        }

        private void frame1_Navigated(object sender, NavigationEventArgs e)
        {

        }


        private void Window_MouseLeftButtonDown(object semder, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();
            frame1.Navigate(settings);
        }
    }
}
