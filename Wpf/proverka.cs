using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Wpf
{
    internal class proverka
    {
        public static bool ValidateInputs(TextBox nameTextBox, TextBox emailTextBox, TextBox passwordTextBox, TextBox repasswordTextBox)
        {
            string name = nameTextBox.Text;
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text.Trim();
            string repassword = repasswordTextBox.Text.Trim();

            if (name.Length < 3)
            {
                nameTextBox.BorderBrush = Brushes.Red;
                return false;
            }
            nameTextBox.BorderBrush = Brushes.Green;

            Regex emailRegex = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
            if (!emailRegex.IsMatch(email))
            {
                emailTextBox.BorderBrush = Brushes.Red;
                return false;
            }
            emailTextBox.BorderBrush = Brushes.Green;

            if (password.Length < 6)
            {
                passwordTextBox.BorderBrush = Brushes.Red;
                return false;
            }
            passwordTextBox.BorderBrush = Brushes.Green;

            if (password != repassword)
            {
                MessageBox.Show("Пароли не совпадают");
                return false;
            }

            return true;
        }
    }
}
