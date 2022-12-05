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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //double rateDollar = Convert.ToDouble(rate.Text);
            //double sumDollar = Convert.ToDouble(sum.Text);
            //double resDollar = rateDollar* sumDollar;
            //resSum.Text = resDollar.ToString();
            ResSum(rateDol.Text, sumDol.Text, resSumDol);
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ResSum(rateEU.Text, sumEU.Text, resSumEU);
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ResSum(rateGR.Text, sumGR.Text, resSumGR);
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ResSum(rateDR.Text, sumDR.Text, resSumDR);
        }
        public static void ResSum(string rateStr , string sumStr , TextBox resSum)
        {
            double rate = Convert.ToDouble(rateStr);
            double sum = Convert.ToDouble(sumStr);
            double res = rate * sum;
            resSum.Text = res.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ToMeter(Inch.Text, 0.0254, resInch);
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            ToMeter(Feet.Text, 0.3048, resFeet);
        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            
            ToMeter(Miles.Text, 1609.34, resMiles);
        }
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            ToMeter(Verst.Text, 1066.8, resVerst);
        }

        public static void ToMeter(string lengthStr, double k, TextBox res)
        {
            double length = Convert.ToDouble(lengthStr);
            double meter = length * k;
            res.Text = meter.ToString();
        }
    }
}
