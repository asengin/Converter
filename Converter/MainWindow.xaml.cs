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

namespace Converter
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
            double numRateDol = Convert.ToDouble(rateDol.Text);
            double numSumDol = Convert.ToDouble(sumDol.Text);
            double numResultDol = numRateDol * numSumDol;
            resultDol.Text = numResultDol.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double numRatePound = Convert.ToDouble(ratePound.Text);
            double numSumPound = Convert.ToDouble(sumPound.Text);
            double numResultPound = numRatePound * numSumPound;
            resultPound.Text = numResultPound.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double numRateEuro = Convert.ToDouble(rateEuro.Text);
            double numSumEuro = Convert.ToDouble(sumEuro.Text);
            double numResultEuro = numRateEuro * numSumEuro;
            resultEuro.Text = numResultEuro.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double numRateYuan = Convert.ToDouble(rateYuan.Text);
            double numSumYuan = Convert.ToDouble(sumYuan.Text);
            double numResultYuan = numRateYuan * numSumYuan;
            resultYuan.Text = numResultYuan.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double numDistMile = Convert.ToDouble(distMile.Text);
            double numResultMile = numDistMile * 1.609;
            resultMile.Text = numResultMile.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double numDistArsh = Convert.ToDouble(distArsh.Text);
            double numResultArsh = numDistArsh * 0.7112;
            resultArsh.Text = numResultArsh.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double numDistFt = Convert.ToDouble(distFt.Text);
            double numResultFt = numDistFt * 0.3048;
            resultFt.Text = numResultFt.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double numDistSpan = Convert.ToDouble(distSpan.Text);
            double numResultSpan = numDistSpan * 17.78;
            resultSpan.Text = numResultSpan.ToString();
        }
    }
}
