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
    /// Логика взаимодействия для Page7.xaml
    /// </summary>
    public partial class Page7 : Page
    {
        public Page7()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(AA.Text);
            string ch = "";
            string t = "";
            if (x % 2 == 0)
            {
                ch = "четное";
            }
            else 
            {
                ch = "нечетное";
            }
            if (x < 10)
            {
                t = "однозначное";
            }
            else if (x >= 10 && x <= 99)
            {
                t = "двухзначное";
            }
            else if (x >= 100 && x <= 999)
            {
                t = "трехзначное";
            }
            MessageBox.Show($"{ch} {t} число", "Ответ");

        }
    }
}
