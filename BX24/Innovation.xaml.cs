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
    /// Логика взаимодействия для Innovation.xaml
    /// </summary>
    public partial class Innovation : Page
    {
        public Innovation()
        {
            InitializeComponent();
        }

        private void TEL_MV_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                @"C:\Program Files (x86)\3CXPhone\3CXPhone.exe",
                @"sip:87473563207");
        }

        private void TELm_KS_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                @"C:\Program Files (x86)\3CXPhone\3CXPhone.exe",
                @"sip:503");
        }

        private void TEL_KM_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                @"C:\Program Files (x86)\3CXPhone\3CXPhone.exe",
                @"sip:301");
        }

        private void TELm_KM_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                @"C:\Program Files (x86)\3CXPhone\3CXPhone.exe",
                @"sip:87054166306");
        }
    }
}
