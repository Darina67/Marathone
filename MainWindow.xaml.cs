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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Manager.MainFrame = MainFrame;
            MainFrame.Navigate(new AuthorizationPage());
        }

        private void BtnFirst_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSecond_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnThird_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            if (Manager.MainFrame.CanGoBack)
                back.Visibility = Visibility.Visible;
            else
                back.Visibility = Visibility.Hidden;
        }

       //коммент
            
        
        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.GoBack();
        }
    }
}
