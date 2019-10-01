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

namespace Raton_y_Teclado
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            RectanguloIzquierdo.Fill = new SolidColorBrush(Colors.Green);
        }

        private void Window_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            RectanguloIzquierdo.Fill = new SolidColorBrush(Colors.White);
        }

        private void Window_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            RectanguloDerecho.Fill = new SolidColorBrush(Colors.Green);
        }

        private void Window_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            RectanguloDerecho.Fill = new SolidColorBrush(Colors.White);
        }

        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
                textBox2.Text = "Ayuda";
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox_foco.Text = ((TextBox)sender).Name;
        }

        private void TextBox_ratonSobre_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBox_ratonSobre.Text = ((TextBox)sender).Name;
        }

        private void TextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBox_ratonSobre.Text = "";
        }


        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            textBox1.CharacterCasing = CharacterCasing.Upper;
        }

        private void TextBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            char[] vocales = "aeiouAEIOU".ToCharArray();
            StringBuilder textoSinVocales = new StringBuilder(tb.Text);
            for (int i = 0; i < tb.Text.Length; i++)
            {
                if (!vocales.Contains(tb.Text[i]))
                    textoSinVocales.Append(tb.Text[i]);

            }
        }
    }
}
