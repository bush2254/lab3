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
    /// Логика взаимодействия для Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        public Page5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(AA.Text);
            double y = double.Parse(BB.Text);
            string s = "";
            if (x >= 0 && x <= 10 && y >= 0 && y <= 5)
            {
                if (x == 0 || x == 10 || y == 0 || y == 5)
                {
                    s = "На границе";
                }
                else { s = "Да"; }
            }
            else { s = "Нет"; }
            MessageBox.Show($"{s}", "Ответ");

        }
    }
}
