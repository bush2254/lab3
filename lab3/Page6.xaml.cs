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
    /// Логика взаимодействия для Page6.xaml
    /// </summary>
    public partial class Page6 : Page
    {
        public Page6()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(AA.Text);
            string z = "";
            string ch = "";
            if (x > 0)
            {
                z = "положительное";
            }
            else if (x < 0)
            {
                z = "отрицательное";
            }
            else
            {
                z = "нулевое";
            }
            if (x % 2 == 0 && x != 0)
            {
                ch = "четное";
            }
            else if (x % 2 == 1 || x%2 == (-1) && x != 0)
            {
                ch = "нечетное";
            }
            MessageBox.Show($"{z} {ch} число", "Ответ");

        }
    }
}
