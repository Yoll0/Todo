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
        UserRepository UR = new UserRepository();
        public MainWindow()
        {
            InitializeComponent();
            //UR.UserRegistration("yollo", "123123", "d3550669@gmail.com");
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
Registr registrPage = new Registr();
var window = Window.GetWindow(this);
if (window != null)
{
    window.Content = registrPage;
}
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            string email = text1.Text; 
            string password = text2.Text; 

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
                MainPage mainPage = new MainPage (user);
                var window = Window.GetWindow(this);
                if (window != null)
                {
                    window.Content = mainPage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return;
            }

        }
    }
}
