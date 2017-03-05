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

namespace ManageMoney
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //double a;
        
        public MainWindow()
        {
            InitializeComponent();
        }

       
        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            label1.Content = "Twoja liczba to ";
   
            label1.Content = label1.Content + b.Content.ToString();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "") label.Content = "Wpisz liczbe";
            else
            {
              
                Money.Count = Double.Parse(textBox.Text);
                Money.Members = int.Parse(textBox_mem.Text);
                
                label.Content = Money.Dim(Money.Count).ToString();
                label2.Content = Money.Bill(Money.Count).ToString();
                label3.Content = Money.mama().ToString();
            }
        }

        private void button_reset_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            textBox_mem.Text = "";
            label.Content = "";
            label2.Content = "";
            label3.Content = "";
        }

        private void textBox_mem_GotFocus(object sender, RoutedEventArgs e)
        {
            textBox_mem.Text = "";
        }
    }
}
