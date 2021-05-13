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
    /// Логика взаимодействия для PersonalPage.xaml
    /// </summary>
    public partial class PersonalPage : Page
    {
        public PersonalPage()
        {
            InitializeComponent();
            DGridRunners.ItemsSource = marathoneEntities.GetContext().runners.ToList();
            DGridStaff.ItemsSource = marathoneEntities.GetContext().staffs.ToList();
        }

        

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Редактирование бегунов временно не работает", "Произогла ошибка");
        }

        private void BtnEdit2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Редактирование персонала временно не работает", "Произогла ошибка");
        }
    }
}
