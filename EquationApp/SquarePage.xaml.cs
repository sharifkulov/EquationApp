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

namespace EquationApp
{
    /// <summary>
    /// Логика взаимодействия для SquarePage.xaml
    /// </summary>
    public partial class SquarePage : Page
    {
        public SquarePage()
        {
            InitializeComponent();
        }
        bool TextBoxISEmpty()
        {
            return (TextBoxB.Text != "" && TextBoxK.Text != "");
        }
        void SolutionEquation(double Value1, double Value2)
        {
            double x;
            
            if (Value1 > 0)
            {
                x = -Value2 / Value1;
                TextBoxResult.Text = "Корень линейного уравнения равен: " + x;
            }
            else if (Value1 == 0)
            {                
                TextBoxResult.Text = "Аргумент К не может быть равен 0";
            }
        }
        private void ButtonResult_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxISEmpty())
            {
                try
                {
                    SolutionEquation(Convert.ToDouble(TextBoxK.Text), Convert.ToDouble(TextBoxB.Text));
                    TextBoxK.Clear();
                    TextBoxB.Clear();
                    
                }
                catch (Exception)
                {

                    MessageBox.Show("Некорректный ввод");
                }

            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }

        }
    }
}
