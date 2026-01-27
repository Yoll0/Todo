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

namespace Wpf
{
    /// <summary>
    /// Логика взаимодействия для Registr.xaml
    /// </summary>
    public partial class Registr : Page
    {
        public Registr()
        {
            InitializeComponent();
        }
        UserRepository UR = new UserRepository();
        proverka Validate = new proverka();

        private void Registration(object sender, RoutedEventArgs e)
        {
            string email = Email.Text.Trim().ToLower();
            string password = PassWord.Text.Trim();
            string rePassword = RePassWord.Text.Trim();
            string login = Name.Text.Trim();

            if (proverka.ValidateInputs(Name, Email, PassWord, RePassWord))
            {
                try
                {
                    var user = UR.UserRegistration(login, password, email);

                    MainPage mainPage = new MainPage(user);
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


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
