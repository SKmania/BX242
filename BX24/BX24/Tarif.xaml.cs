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
    /// Логика взаимодействия для Tarif.xaml
    /// </summary>
    public partial class Tarif : Page
    {
        public Tarif()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            podrobnyainfa podrobnyainfa = new podrobnyainfa();
            navreportdeep.Navigate(podrobnyainfa);
            gridreport.Visibility = Visibility.Collapsed;
            navreportdeep.Visibility = Visibility.Visible;
        }
    }
}
