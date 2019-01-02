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

namespace BX24
{
    /// <summary>
    /// Логика взаимодействия для telecom.xaml
    /// </summary>
    public partial class telecom : Page
    {
        public telecom()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Leadership leadership = new Leadership();
            frame1.Navigate(leadership);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Innovation innovation = new Innovation();
            frame1.Navigate(innovation);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Web web = new Web();
            frame1.Navigate(web);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Sale sale = new Sale();
            frame1.Navigate(sale);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Project project = new Project();
            frame1.Navigate(project);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Programm programm = new Programm();
            frame1.Navigate(programm);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Book book = new Book();
            frame1.Navigate(book);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Escort escort = new Escort();
            frame1.Navigate(escort);
        }
    }
}
