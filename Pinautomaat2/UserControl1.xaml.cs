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

namespace Pinautomaat2
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        int iSaldo;
        public UserControl1(int iSaldo)
        {
            this.iSaldo = iSaldo;
            InitializeComponent();
            saldo.Content = "Uw saldo is: " + iSaldo;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("U heeft nu 10 euro");
            iSaldo -= 10;
            saldo.Content = "Uw saldo is " + iSaldo;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("U heeft nu 20 euro");
            iSaldo -= 20;
            saldo.Content = "Uw saldo is " + iSaldo;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("U heeft nu 50 euro");
            iSaldo -= 50;
            saldo.Content = "Uw saldo is " + iSaldo;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("U heeft nu 100 euro");
            iSaldo -= 100;
            saldo.Content = "Uw saldo is " + iSaldo;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("U heeft nu 200 euro");
            iSaldo -= 200;
            saldo.Content = "Uw saldo is " + iSaldo;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("U heeft nu 500 euro");
            iSaldo -= 500;
            saldo.Content = "Uw saldo is " + iSaldo;
        }
    }
}
