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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf
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
            Window1 window1 = new Window1();
            window1.Show();
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // Получаем значения из TextBox
            string email = text1.Text; // Замените на имя вашего TextBox для почты
            string password = text2.Text; // Замените на имя вашего TextBox для пароля

            // Проверяем почту по паттерну "*@*.*"
            if (!Regex.IsMatch(email, @"^.+@.+\..+$"))
            {
                MessageBox.Show("Введите корректный адрес электронной почты.");
                return; // Выход из метода, если почта некорректная
            }

            // Проверяем длину пароля
            if (password.Length < 6)
            {
                MessageBox.Show("Пароль должен содержать не менее 6 символов.");
                return; // Выход из метода, если пароль некорректный
            }

            // Проверяем, соответствует ли почта и пароль заданным значениям
            if (email == "test@gmail.com" && password == "test123")
            {
                Main_empty main_Empty = new Main_empty();
                main_Empty.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверные учетные данные.");
            }


        }
    }
}
