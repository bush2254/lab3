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

namespace lab3
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(AA.Text);
            double b = double.Parse(BB.Text);
            double c = double.Parse(CC.Text);
            double discriminant = b * b - 4 * a * c;
            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                MessageBox.Show($" имеет решение,x1={x1} x2={x2} ", "ответ");
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                MessageBox.Show($"имеет решение, x={x} ", "ответ");
            }
            else
            {
                MessageBox.Show($" нет решения ", "ответ");
            }

        }
    }
}
