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
    /// Логика взаимодействия для InteracriveMap.xaml
    /// </summary>
    public partial class InteracriveMap : Page
    {
        public InteracriveMap()
        {
            InitializeComponent();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Особенности: \n -Стенд питья \n -Энергетические батончики \n -Туалет \n - Медицинский пункт ","Остановка 1");
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Особенности: \n -Сцена \n -Трибуны \n -Туалет \n -VIP ложа  ", "Остановка 2");
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Особенности: \n -Вход для посетителей \n -Детский городок  ", "Остановка 3");
        }

        private void Image_MouseDown_3(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Особенности: \n -Стенд фастфуда \n -Операторская \n -Коментаторская будка \n - Медицинский пункт ", "Остановка 4");
        }

        private void Image_MouseDown_4(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Особенности: \n -Финиш ","Финиш");
        }
    }
}
