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
using static System.Math;
namespace lab3
{
    /// <summary>
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(AA.Text);
            double p = 3.14;
            double y=0;

            if (x < p / 2 && x > -p / 2)
            {
                y = Sqrt(Abs((Sin(x) + Pow(Tan(x), 2)) / (3.5 * Cos(x))));
                   MessageBox.Show($" y={y}", "ответ");
            }
            else if (x > p / 2 && x < p)
            {
                y = Cos(x / 3) / (Sin(x) + Pow(Tan(x), 2));
                MessageBox.Show($" y={y}", "ответ");
            }
            else
            {
                MessageBox.Show($" ошибка", "ответ");
            }

        }
    }
}
