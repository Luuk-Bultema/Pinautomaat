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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtPincode9.Text += "1";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (txtPincode9.Text == "4689")
            {
                MessageBox.Show("U kunt nu uw saldo opnemen");
                UserControl1 uc = new UserControl1(1000);
                deGrid.Children.Clear();
                deGrid.Children.Add(uc);
            }
            else
            {
                MessageBox.Show("Uw pincode is onjuist, probeer het opnieuw");
            }

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
 
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            txtPincode9.Text += "2";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            txtPincode9.Text += "3";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            txtPincode9.Text += "4";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            txtPincode9.Text += "5";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            txtPincode9.Text += "6";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            txtPincode9.Text += "7";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            txtPincode9.Text += "8";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            txtPincode9.Text += "9";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            txtPincode9.Text += "*";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            txtPincode9.Text += "0";
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            txtPincode9.Text += "#";
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            txtPincode9.Text += "";
        }
    }
}
