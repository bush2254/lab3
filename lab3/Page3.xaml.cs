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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(AA.Text);
            int b = int.Parse(BB.Text);
            int c = int.Parse(CC.Text);
            if ((a < b && b < c) || (a > b && b > c))
            {
                a = 2 * a;
                b = 2 * b;
                c = 2 * c;
            }
            else
            {
                a = -a;
                b = -b;
                c = -c;
            }
            MessageBox.Show($" a={a} b={b} c={c}", "ответ");

        }
    }
 }

