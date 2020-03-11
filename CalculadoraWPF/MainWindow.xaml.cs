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

namespace CalculadoraWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double primera_Entrada;
        double segunda_Entrada;
        double resultado;
        string operador;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Presiona_Cero(object sender, RoutedEventArgs e)
        {
            Textbox_Screen.Text = Textbox_Screen.Text + "0"; 
        }

        private void Presiona_Uno(object sender, RoutedEventArgs e)
        {
            Textbox_Screen.Text = Textbox_Screen.Text + "1";
        }

        private void Presiona_Dos(object sender, RoutedEventArgs e)
        {
            Textbox_Screen.Text = Textbox_Screen.Text + "2";
        }

        private void Presiona_Tres(object sender, RoutedEventArgs e)
        {
            Textbox_Screen.Text = Textbox_Screen.Text + "3";
        }

        private void Presiona_Cuatro(object sender, RoutedEventArgs e)
        {
            Textbox_Screen.Text = Textbox_Screen.Text + "4";
        }

        private void Presiona_Cinco(object sender, RoutedEventArgs e)
        {
            Textbox_Screen.Text = Textbox_Screen.Text + "5";
        }

        private void Presiona_Seis(object sender, RoutedEventArgs e)
        {
            Textbox_Screen.Text = Textbox_Screen.Text + "6";
        }

        private void Presiona_Siete(object sender, RoutedEventArgs e)
        {
            Textbox_Screen.Text = Textbox_Screen.Text + "7";
        }

        private void Presiona_Ocho(object sender, RoutedEventArgs e)
        {
            Textbox_Screen.Text = Textbox_Screen.Text + "8";
        }

        private void Presiona_Nueve(object sender, RoutedEventArgs e)
        {
            Textbox_Screen.Text = Textbox_Screen.Text + "9";
        }

        private void Presiona_Sumar(object sender, RoutedEventArgs e)
        {
            operador = "+";
            primera_Entrada = double.Parse(Textbox_Screen.Text);
            Textbox_Screen.Clear();
        }

        private void Presiona_Restar(object sender, RoutedEventArgs e)
        {
            operador = "-";
                primera_Entrada = double.Parse(Textbox_Screen.Text);
                Textbox_Screen.Clear();
        }

        private void Presiona_Multiplicar(object sender, RoutedEventArgs e)
        {
            operador = "*";
            primera_Entrada = double.Parse(Textbox_Screen.Text);
            Textbox_Screen.Clear();
        }

        private void Presiona_Dividir(object sender, RoutedEventArgs e)
        {
            operador = "/";
            primera_Entrada = double.Parse(Textbox_Screen.Text);
            Textbox_Screen.Clear();
        }

        private void Presiona_Punto(object sender, RoutedEventArgs e)
        {
            if (Textbox_Screen.Text.Contains("."))
            {

            }
            else
            {
                Textbox_Screen.Text = Textbox_Screen.Text + ".";
            }
        }

        private void Presiona_Igual(object sender, RoutedEventArgs e)
        {
            segunda_Entrada = double.Parse(Textbox_Screen.Text);
            switch (operador)
            {
                case "+":
                    resultado = primera_Entrada + segunda_Entrada;
                    Textbox_Screen.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = primera_Entrada - segunda_Entrada;
                    Textbox_Screen.Text = resultado.ToString();
                    break;
                case "*":
                    resultado = primera_Entrada * segunda_Entrada;
                    Textbox_Screen.Text = resultado.ToString();
                    break;
                case "/":
                    resultado = primera_Entrada / segunda_Entrada;              
                    Textbox_Screen.Text = resultado.ToString();
                    break;
            }
        }

        private void Presiona_Clear(object sender, RoutedEventArgs e)
        {
            Textbox_Screen.Clear();
        }
    }
}
