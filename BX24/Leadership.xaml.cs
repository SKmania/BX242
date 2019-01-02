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
    /// Логика взаимодействия для Leadership.xaml
    /// </summary>
    public partial class Leadership : Page
    {
        public Leadership()
        {
            InitializeComponent();
        }

        private void TELm_GI_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                @"C:\Program Files (x86)\3CXPhone\3CXPhone.exe",
                @"sip:87142917230");
        }

        private void TEL_JE_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                @"C:\Program Files (x86)\3CXPhone\3CXPhone.exe",
                @"sip:502");
        }
    }
}
