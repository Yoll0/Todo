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
    /// Логика взаимодействия для MainWindiw_p_.xaml
    /// </summary>
    public partial class MainWindiw_p_ : Page
    {
        public MainWindiw_p_()
        {
            InitializeComponent();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Оставьте пустым или добавьте логику при необходимости
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            // Оставьте пустым или добавьте логику при необходимости
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            // Переход на страницу регистрации
            NavigationService.Navigate(new Registr());
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string email = text1.Text.Trim();
            string password = text2.Text.Trim();

            if (!Regex.IsMatch(email, @"^.+@.+\..+$"))
            {
                MessageBox.Show("Введите корректный адрес электронной почты.");
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Пароль должен содержать не менее 6 символов.");
                return;
            }

            try
            {
                var user = UR.UserAuthenticate(email, password);

                // Переход на главную страницу после успешной авторизации
                Main_empty mainPage = new Main_empty(user);
                NavigationService.Navigate(mainPage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return;
            }
        }
    }
}
