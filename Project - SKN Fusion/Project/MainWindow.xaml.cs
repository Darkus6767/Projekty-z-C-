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

namespace Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double value = 0;
        string operation = "";
        bool operation_pressed; // sprawdza czy znak operacji jest wcisnięty
        bool flag = false;
        
        public MainWindow()
        {
            InitializeComponent();
          
        }
        #region podstawowa_funkcjonalnosc

        private void number_Click(object sender, RoutedEventArgs e)
        {
            if ((resultBox.Text == "0")|| (operation_pressed)) 
                resultBox.Clear();
            if (flag == true)
            {
                value = 0;
                resultBox.Clear();
            }
            flag = false;
            operation_pressed = false;
            Button b = (Button)sender;
            resultBox.Text = resultBox.Text + b.Content.ToString();
        }

        private void resultBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void operation_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            // przypadek gdy jest już jakaś wartość, po nacisnięciu przycisku operacji od razu zwróci nam wartość działania
            // nie trzeba za każdym razem wciskac znaku równości/entera
            if (value != 0) 
            {
                result.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                operation_pressed = true;
                operation = b.Content.ToString();
                Equation.Content = value + " " + operation;

            }
            
            else
            {
                operation = b.Content.ToString();
                value = Double.Parse(resultBox.Text);
                operation_pressed = true;
                Equation.Content = value + " " + operation;
            }
        }

        private void result_Click(object sender, RoutedEventArgs e)
        {
            flag = true;
            Equation.Content = "";
            switch (operation)
            {
              
                case "+":
                    resultBox.Text = OperationsTwoNum.Add(value, Double.Parse(resultBox.Text)).ToString();
                    value = Double.Parse(resultBox.Text);
                    break;
                case "-":
                    resultBox.Text = OperationsTwoNum.Subs(value, Double.Parse(resultBox.Text)).ToString();
                    value = Double.Parse(resultBox.Text);
                    break;
                case "*":
                    resultBox.Text = OperationsTwoNum.Multi(value , Double.Parse(resultBox.Text)).ToString();
                    value = Double.Parse(resultBox.Text);
                    break;
                case "/":
                    resultBox.Text = OperationsTwoNum.Divide (value ,Double.Parse(resultBox.Text)).ToString();
                    value = Double.Parse(resultBox.Text);
                    break;
                case "^":
                    resultBox.Text = OperationsTwoNum.Power(value, Double.Parse(resultBox.Text)).ToString();
                    value = Double.Parse(resultBox.Text);
                    break;
                default:
                    break;     
            }
            
            operation = "";
            operation_pressed = false;
        }

        private void comma_Click(object sender, RoutedEventArgs e)
        {
            if (operation_pressed)
                resultBox.Text = "0,";
            else
                resultBox.Text += ",";
            operation_pressed = false;
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            resultBox.Text = "0";
            value = 0;
            Equation.Content = "";
        }
        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if (resultBox.Text.Length > 0)
            {
                resultBox.Text = resultBox.Text.Remove(resultBox.Text.Length - 1);
            }
        }

        private void internet_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://fusion.polsl.pl");
        }
        #endregion

        #region obsluga_klawiatury_numerycznej
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
           
            switch (e.Key)
            {
                
                case Key.NumPad0:
                    number0.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.NumPad1:
                    number1.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.NumPad2:
                    number2.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.NumPad3:
                    number3.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.NumPad4:
                    number4.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.NumPad5:
                    number5.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.NumPad6:
                    number6.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.NumPad7:
                    number7.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.NumPad8:
                    number8.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.NumPad9:
                    number9.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.Add:
                    add.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.Subtract:
                    subs.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.Divide:
                    division.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.Multiply:
                    multiplication.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.Enter:
                    result.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.Decimal:
                    comma.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                default:
                    break;
                    
            }
        }
        #endregion
    

        #region OneNumOperations
        private void strong_Click(object sender, RoutedEventArgs e)
        {
            resultBox.Text = OperationOneNum.Strong(Double.Parse(resultBox.Text)).ToString();
           
        }
        private void Negation_Click(object sender, RoutedEventArgs e)
        {
            resultBox.Text = OperationOneNum.Neg(Double.Parse(resultBox.Text)).ToString();
        }
        private void binSys_Click(object sender, RoutedEventArgs e)
        {
            resultBox.Text = OperationOneNum.Convert(Int32.Parse(resultBox.Text),2).ToString();
        }
        private void hexSys_Click(object sender, RoutedEventArgs e)
        {
            resultBox.Text = OperationOneNum.Convert(Int32.Parse(resultBox.Text), 16).ToString();
        }
        private void Fib_Click(object sender, RoutedEventArgs e)
        {
            resultBox.Text = OperationOneNum.Fib(UInt32.Parse(resultBox.Text)).ToString();
        }
        #endregion

       
    }
    
}
