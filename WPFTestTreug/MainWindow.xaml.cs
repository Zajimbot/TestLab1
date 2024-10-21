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
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {
            int a, b, c;
            try
            {
                a = Convert.ToInt32(A.Text);
                b = Convert.ToInt32(B.Text);
                c = Convert.ToInt32(C.Text);
            }
            catch (Exception ex)
            {
                Result.Text = ex.Message;
                return;
            }
            if (a == b && b == c)
            {
                Result.Text = "Равносторонний треугольник";
                string photo = Environment.CurrentDirectory + "\\RS.png";
                Uri uri = new Uri(photo, UriKind.Absolute);
                BitmapImage bitmapImage = new BitmapImage(uri);
                TR.Source = bitmapImage;
            }else
            if (a == c && b != a && b != c)
            {
                Result.Text = "Равнобедренный треугольник";
                string photo = Environment.CurrentDirectory + "\\RB.png";
                Uri uri = new Uri(photo, UriKind.Absolute);
                BitmapImage bitmapImage = new BitmapImage(uri);
                TR.Source = bitmapImage;
            }else
            if (a == b && c != a && c != b)
            {
                Result.Text = "Равнобедренный треугольник";
                string photo = Environment.CurrentDirectory + "\\RB.png";
                Uri uri = new Uri(photo, UriKind.Absolute);
                BitmapImage bitmapImage = new BitmapImage(uri);
                TR.Source = bitmapImage;
            }else
            if(b == c && a != c && a != b)
            {
                Result.Text = "Равнобедренный треугольник";
                string photo = Environment.CurrentDirectory + "\\RB.png";
                Uri uri = new Uri(photo, UriKind.Absolute);
                BitmapImage bitmapImage = new BitmapImage(uri);
                TR.Source = bitmapImage;
            }
            else
            if (a != b && a != c && b != c && a + b >= c && a + c >= b && b + c >= a  )
            {               
                    Result.Text = "Разносторонний треугольник";
                    string photo = Environment.CurrentDirectory + "\\RasS.png";
                    Uri uri = new Uri(photo, UriKind.Absolute);
                    BitmapImage bitmapImage = new BitmapImage(uri);
                    TR.Source = bitmapImage;                
            }else
            { 
                if (a + b < c || a + c < b || b + c < a || a < 0 || b < 0 || c < 0)
                {
                    Result.Text = "Треугольник не существует ";
                    TR.Source = null;
                    
                    string photo = Environment.CurrentDirectory + "\\N.png";
                    Uri uri = new Uri(photo, UriKind.Absolute);
                    BitmapImage bitmapImage = new BitmapImage(uri);
                    TR.Source = bitmapImage;
                }
            }
        }
    }
}
