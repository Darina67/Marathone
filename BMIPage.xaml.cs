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
    /// Логика взаимодействия для BMIPage.xaml
    /// </summary>
    public partial class BMIPage : Page
    {
        
        public BMIPage()
        {
            InitializeComponent();
           
        }
        
        
       
        private void metBmiCalc_Click(object sender, RoutedEventArgs e)
        {
            double X;
            double Y;
            double Z;

           
             X = Convert.ToDouble(textbox1.Text);
            X = X / 100;
             Y = Convert.ToDouble(textbox2.Text);
             Z = Y / (Math.Pow(X, 2));
            
            slider.Value = Z;
            
           /* if (Z<18)
            {
                slider.Value = Z;
            }
            if (Z > 30)
            {
                slider.Value = 60;
            }
            if (Z>18 & Z<30)
            {
                slider.Value = 25;
            }
            */
        }

                  private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("С помощью индекса массы тела вы можете проверить соответствие между массой вашего тела и вашим ростом и узнать, имеется ли у вас избыточный вес, или же, наоборот, не страдаете ли вы недостатком веса. Чтобы рассчитать индекс массы вашего тела (ИМТ) заполните в калькуляторе поля, соответствующие значениям вашего роста и веса.", "Калькулятор массы тела");
        }
    }
}
