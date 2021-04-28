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

namespace Marathone
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void BtnThird_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSecond_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnFirst_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new FirstPage());
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
