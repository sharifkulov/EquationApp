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
    /// Логика взаимодействия для LinearPage.xaml
    /// </summary>
    public partial class LinearPage : Page
    {
        public LinearPage()
        {
            InitializeComponent();
        }
        bool TextBoxISEmpty()
        {
            return (TextBoxA.Text != "" && TextBoxB.Text != "" && TextBoxC.Text != "");
        }
        void SolutionEquation(double Value1, double Value2, double Value3)
        {
            double D, x1,x2;
            D = Math.Pow(Value2, 2) - 4 * Value1 * Value3;
            if (D > 0)
            {
                x1 = (-Value2 + Math.Sqrt(D)) / (2 * Value1);
                x2 = (-Value2 - Math.Sqrt(D)) / (2 *Value1);
                TextBoxResult.Text = "Первый корень квадратного уравнения: "+ x1 + "\nВторой корень квадратного уравнения: " +x2;
            }
            else if (D==0)
            {
                x1=(-Value2)/(2* Value1);
                TextBoxResult.Text = "Дискрименант равен 0, значит это уравнение будет иметь один корень"+x1;
            }
            else
            {
                TextBoxResult.Text = ("Дискрименант меньше нуля, значит корней у этого уравнения нет.").ToString();
            }
        }

        private void ButtonResult_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxISEmpty())
            {
                try
                {
                    SolutionEquation(Convert.ToDouble(TextBoxA.Text), Convert.ToDouble(TextBoxB.Text), Convert.ToDouble(TextBoxC.Text));
                    TextBoxA.Clear();
                    TextBoxB.Clear();
                    TextBoxC.Clear();
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
