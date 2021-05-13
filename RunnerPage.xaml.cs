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
    /// Логика взаимодействия для RunnerPage.xaml
    /// </summary>
    public partial class RunnerPage : Page
    {
        public RunnerPage()
        {
            InitializeComponent();
            DGridRunners.ItemsSource = marathoneEntities.GetContext().runners.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show( "Для получения дополнительной информации пожалуйста свяжитесь с координатором \n Телефон: +55 11 9988 7766 \n Email: coordinators@marathon.org", "Контакты");
        }
    }
}
