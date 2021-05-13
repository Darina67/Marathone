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
    /// Логика взаимодействия для RegistratePage.xaml
    /// </summary>
    /// Сделано на ноуте Дарины в 9:06 в апреле
    public partial class RegistratePage : Page
    {
        private runner _currentRunners = new runner();
        public RegistratePage(runner selectedRunner)
        {
            InitializeComponent();
            if (selectedRunner != null)
                _currentRunners = selectedRunner;
            DataContext = _currentRunners;
        }

        private void Savebtn_Click(object sender, RoutedEventArgs e)
        {
            if (List.Text =="Бегун")
            { 
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentRunners.Name))
                errors.AppendLine("Введите Имя");
            if (string.IsNullOrWhiteSpace(_currentRunners.Surname))
                errors.AppendLine("Введите Фамилию");
            if (string.IsNullOrWhiteSpace(_currentRunners.Sex))
                errors.AppendLine("Введите Пол (М или Ж)");
            if (string.IsNullOrWhiteSpace(_currentRunners.Email))
                errors.AppendLine("Введите Почту");
            if (string.IsNullOrWhiteSpace(_currentRunners.Password))
                errors.AppendLine("Введите Пароль");
                if (password.Text != password_repeat.Text)
                    MessageBox.Show("пароли не совпадают");
            if (string.IsNullOrWhiteSpace(_currentRunners.Country))
                errors.AppendLine("Введите Страну");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentRunners.IdOfRunner == 0)
                marathoneEntities.GetContext().runners.Add(_currentRunners);
            try
            {
                marathoneEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                Manager.MainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            }
            else
            {
                MessageBox.Show("Вы не бегун. В данный момент регистрация доступна только бегунам");
            }
        }

        private void sex_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void name_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (sender is TextBox textBox)
            {

                textBox.Text = new string
                    (
                         textBox
                         .Text
                         .Where
                         (ch =>
                            (ch >= 'а' && ch <= 'я')
                            || (ch >= 'А' && ch <= 'Я')
                            || ch == 'ё' || ch == 'Ё'
                         )
                         .ToArray()
                    );
            }
        }

        private void surname_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (sender is TextBox textBox)
            {

                textBox.Text = new string
                    (
                         textBox
                         .Text
                         .Where
                         (ch =>
                            (ch >= 'а' && ch <= 'я')
                            || (ch >= 'А' && ch <= 'Я')
                            || ch == 'ё' || ch == 'Ё'
                         )
                         .ToArray()
                    );
            }
        }

        private void country_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (sender is TextBox textBox)
            {

                textBox.Text = new string
                    (
                         textBox
                         .Text
                         .Where
                         (ch =>
                            (ch >= 'а' && ch <= 'я')
                            || (ch >= 'А' && ch <= 'Я')
                            || ch == 'ё' || ch == 'Ё'
                         )
                         .ToArray()
                    );
            }
        }
    }
}
