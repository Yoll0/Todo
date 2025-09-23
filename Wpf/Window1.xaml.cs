using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Wpf
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string name = textBox.Text;

            if (name.Length >= 3)
            {
                // Имя валидное
                textBox.BorderBrush = Brushes.Green;
            }
            else
            {
                // Имя невалидное
                textBox.BorderBrush = Brushes.Red;
            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string email = textBox.Text;

            // Проверяем email по шаблону "*@*.*"
            Regex emailRegex = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
            if (emailRegex.IsMatch(email))
            {
                // Email валидный
                textBox.BorderBrush = Brushes.Green;
            }
            else
            {
                // Email невалидный
                textBox.BorderBrush = Brushes.Red;
            }
        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string password = textBox.Text;

            if (password.Length >= 6)
            {
                // Пароль валидный
                textBox.BorderBrush = Brushes.Green;
            }
            else
            {
                // Пароль невалидный
                textBox.BorderBrush = Brushes.Red;
            }
        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {
            TextBox passwordTextBox = (TextBox)this.FindName("PasswordTextBox");
            TextBox confirmPasswordTextBox = (TextBox)this.FindName("ConfirmPasswordTextBox");

            // Проверяем, что пароль и подтверждение пароля валидны
            string password = passwordTextBox?.Text ?? string.Empty;
            string confirmPassword = confirmPasswordTextBox?.Text ?? string.Empty;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Main_empty main_Empty = new Main_empty();
            main_Empty.Show();
            this.Close();
        }
    }
}
