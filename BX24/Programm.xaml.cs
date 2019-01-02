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
    /// Логика взаимодействия для Programm.xaml
    /// </summary>
    public partial class Programm : Page
    {
        public Programm()
        {
            InitializeComponent();
        }

        private void TEL_TM_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                @"C:\Program Files (x86)\3CXPhone\3CXPhone.exe",
                @"sip:406");
        }

        private void TELm_TM_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                @"C:\Program Files (x86)\3CXPhone\3CXPhone.exe",
                @"sip:87760120108");
        }

        private void TEL_KM_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                @"C:\Program Files (x86)\3CXPhone\3CXPhone.exe",
                @"sip:402");
        }

        private void TELm_KM_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                @"C:\Program Files (x86)\3CXPhone\3CXPhone.exe",
                @"sip:87072477260");
        }

        private void TEL_MA_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                @"C:\Program Files (x86)\3CXPhone\3CXPhone.exe",
                @"sip:408");
        }

        private void TELm_MA_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                @"C:\Program Files (x86)\3CXPhone\3CXPhone.exe",
                @"sip:87772215588");
        }
    }
}
