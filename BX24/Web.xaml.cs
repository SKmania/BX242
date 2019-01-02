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
    /// Логика взаимодействия для Web.xaml
    /// </summary>
    public partial class Web : Page
    {
        public Web()
        {
            InitializeComponent();
        }

        private void TELm_MV_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                @"C:\Program Files (x86)\3CXPhone\3CXPhone.exe",
                @"sip:87473563207");
        }

        private void TEL_IS_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                @"C:\Program Files (x86)\3CXPhone\3CXPhone.exe",
                @"sip:403");
        }

        private void TELm_IS_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                @"C:\Program Files (x86)\3CXPhone\3CXPhone.exe",
                @"sip:87070432592");
        }

        private void TEL_RI_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                @"C:\Program Files (x86)\3CXPhone\3CXPhone.exe",
                @"sip:405");
        }

        private void TELm_RI_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                @"C:\Program Files (x86)\3CXPhone\3CXPhone.exe",
                @"sip:87770538736");
        }

        private void TELm_IB_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                @"C:\Program Files (x86)\3CXPhone\3CXPhone.exe",
                @"sip:87774426930");
        }

        private void TEL_MV_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
