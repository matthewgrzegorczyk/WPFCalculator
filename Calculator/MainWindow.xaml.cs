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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            int min_width = 250;
            this.MinWidth = this.Width > min_width ? this.Width : min_width;
            this.MinHeight = this.Height;
        }

        private void OnCalculate(object sender, RoutedEventArgs e)
        {
            try
            {
                int a = int.Parse(first_number.Text);
                int b = int.Parse(second_number.Text);
                string op = operation.Text;

                switch (op)
                {
                    case "+":
                        output.Text = (a + b).ToString();
                        break;
                    case "-":
                        output.Text = (a - b).ToString();
                        break;
                    case "/":
                        output.Text = (a / b).ToString();
                        break;
                    case "*":
                        output.Text = (a * b).ToString();
                        break;
                    default:
                        MessageBox.Show("Houston mamy problem: Nieprawidłowy operator.");
                        break;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Dżejms Błont się wkradł.");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Dżejms Błont nie pozwala dzielić przez 0.");
            }
        }
    }
}
