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

namespace WPFTestTreug
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {
            int a, b, c;
            string photo;
            try
            {
                a = Convert.ToInt32(A.Text);
                b = Convert.ToInt32(B.Text);
                c = Convert.ToInt32(C.Text);
                if (a < 0 || b < 0 || c < 0)
                {
                    Result.Text = "Числа должны быть положительными";
                    TR.Source = null;
                    return;
                }
                if(a > 1000000000 || b > 1000000000 || c > 1000000000)
                {

                    Result.Text = "Числа не должны быть болше 1000000000";
                    TR.Source = null;
                    return;
                }
            }
            catch (Exception ex)
            {
                Result.Text = ex.Message;
                TR.Source = null;
                return;
            }
            A.Text = Convert.ToString(a);
            B.Text = Convert.ToString(b);
            C.Text = Convert.ToString(c);

            if (a + b < c || a + c < b || b + c < a || a < 0 || b < 0 || c < 0)
            {
                Result.Text = "Треугольник не существует ";
                TR.Source = null;

                photo = Environment.CurrentDirectory + "\\N.png";
            }
            else
            if (a == b && b == c)
            {
                Result.Text = "Равносторонний треугольник";
                photo = Environment.CurrentDirectory + "\\RS.png";
            }
            else
            if (a != b && a != c && b != c)
            {
                Result.Text = "Разносторонний треугольник";
                photo = Environment.CurrentDirectory + "\\RasS.png";
            }
            else
            {
                Result.Text = "Равнобедренный треугольник";
                photo = Environment.CurrentDirectory + "\\RB.png";
            }
            Uri uri = new Uri(photo, UriKind.Absolute);
            BitmapImage bitmapImage = new BitmapImage(uri);
            TR.Source = bitmapImage;
        }
    }
}
