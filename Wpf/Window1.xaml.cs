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
        UserRepository UR = new UserRepository();

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
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string name = Name.Text;
            string email = Email.Text;
            string password = PassWord.Text.Trim();
            string repassword = RePassWord.Text.Trim();
//
            if (name.Length >= 3)
            {
                // Имя валидное
                Name.BorderBrush = Brushes.Green;
            }
            else
            {
                // Имя невалидное
                Name.BorderBrush = Brushes.Red;
                return;
            }
//
            Regex emailRegex = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
            if (emailRegex.IsMatch(email))
            {
                // Email валидный
                Email.BorderBrush = Brushes.Green;
            }
            else
            {
                // Email невалидный
                Email.BorderBrush = Brushes.Red;
                return;
            }

            //

            if (password.Length >= 6)
            {
                // Пароль валидный
                PassWord.BorderBrush = Brushes.Green;
            }
            else
            {
                // Пароль невалидный
                PassWord.BorderBrush = Brushes.Red;
                return;
            }
            //
            if (password != repassword)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }


            if (UR.UserRegistration(name, password, email))
            {
                Main_empty main_Empty = new Main_empty();
                main_Empty.Show();
                this.Close();
            }
            else
            {
                return;
            }

        }
    }
}
