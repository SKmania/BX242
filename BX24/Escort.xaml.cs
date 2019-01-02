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
    /// Логика взаимодействия для Escort.xaml
    /// </summary>
    public partial class Escort : Page
    {
        public Escort()
        {
            InitializeComponent();
        }

        private void TEL_JK_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                @"C:\Program Files (x86)\3CXPhone\3CXPhone.exe",
                @"sip:210");
        }

        private void TELm_JK_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                @"C:\Program Files (x86)\3CXPhone\3CXPhone.exe",
                @"sip:87770371630");
        }

        private void TEL_KA_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                @"C:\Program Files (x86)\3CXPhone\3CXPhone.exe",
                @"sip:208");
        }

        private void TELm_KA_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                @"C:\Program Files (x86)\3CXPhone\3CXPhone.exe",
                @"sip:87083577721");
        }

        private void TEL_AE_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                @"C:\Program Files (x86)\3CXPhone\3CXPhone.exe",
                @"sip:209");
        }

        private void TELm_AE_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                @"C:\Program Files (x86)\3CXPhone\3CXPhone.exe",
                @"sip:87059888908");
        }

        private void TEL_MJ_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TEL_Ka_Click_1(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                @"C:\Program Files (x86)\3CXPhone\3CXPhone.exe",
                @"sip:207");
        }

        private void TELm_Ka_Click_1(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                @"C:\Program Files (x86)\3CXPhone\3CXPhone.exe",
                @"sip:87088802704");
        }

        private void TEL_AD_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                @"C:\Program Files (x86)\3CXPhone\3CXPhone.exe",
                @"sip:201");
        }

        private void TELm_AD_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                @"C:\Program Files (x86)\3CXPhone\3CXPhone.exe",
                @"sip:87476304226");
        }

        private void TEL_BA_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                @"C:\Program Files (x86)\3CXPhone\3CXPhone.exe",
                @"sip:206");
        }

        private void TELm_BA_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                @"C:\Program Files (x86)\3CXPhone\3CXPhone.exe",
                @"sip:87772159168");
        }

        private void TEL_RB_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TELm_RB_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                @"C:\Program Files (x86)\3CXPhone\3CXPhone.exe",
                @"sip:87754359856");
        }

        private void TEL_DN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TELm_DN_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                @"C:\Program Files (x86)\3CXPhone\3CXPhone.exe",
                @"sip:87474399280");
        }

        private void TEL_OO_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                @"C:\Program Files (x86)\3CXPhone\3CXPhone.exe",
                @"sip:205");
        }

        private void TELm_OO_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                @"C:\Program Files (x86)\3CXPhone\3CXPhone.exe",
                @"sip:87014663474");
        }

        private void TELm_AN_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                @"C:\Program Files (x86)\3CXPhone\3CXPhone.exe",
                @"sip:87058100510");
        }
    }
}
