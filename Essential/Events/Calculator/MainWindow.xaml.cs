using System;
using System.Windows;

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
        }

        public delegate double OperationsDelegate(int a, int b);

        public static double Add(int a, int b) => a + b;
        public static double Sub(int a, int b) => a - b;
        public static double Div(int a, int b) => a / (double)b;
        public static double Mul(int a, int b) => a * b;

        public OperationsDelegate GetUserOperation()
        {
            OperationsDelegate operation = null;

            if (AdditionRadioButton.IsChecked.HasValue && AdditionRadioButton.IsChecked.Value)
            {
                operation = MainWindow.Add;
            }

            if (SubtractionRadioButton.IsChecked.HasValue && SubtractionRadioButton.IsChecked.Value)
            {
                operation = MainWindow.Sub;
            }

            if (DivisionRadioButton.IsChecked.HasValue && DivisionRadioButton.IsChecked.Value)
            {
                operation = MainWindow.Div;
            }

            if (MultiplicationRadioButton.IsChecked.HasValue && MultiplicationRadioButton.IsChecked.Value)
            {
                operation = MainWindow.Mul;
            }
            return operation;
        }
        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            int intA;
            int intB;
            string stringA = ATextBox.Text;
            string stringB = BTextBox.Text;
            bool isAParsed = Int32.TryParse(stringA, out intA);
            bool isBParsed = Int32.TryParse(stringB, out intB);

            if (isAParsed && isBParsed)
            {
                OperationsDelegate operation = GetUserOperation();

                if (operation == Div && intB == 0)
                {
                    MessageBox.Show("Division by zero is prohibited!");
                    return;
                }

                double result = operation(intA, intB);

                ResultTextBox.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Incorrect input");
            }
        }
    }
}
