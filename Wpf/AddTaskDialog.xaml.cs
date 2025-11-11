using Entities;
using Entities;
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
using System.Windows.Shapes;
using static System.Net.WebRequestMethods;

namespace Wpf
{
    /// <summary>
    /// Логика взаимодействия для AddTaskDialog.xaml
    /// </summary>
    public partial class AddTaskDialog : Window
    {
        private UserModel _currentUser;
        TaskRepository TR = new TaskRepository();

        public AddTaskDialog(UserModel user)
        {
            InitializeComponent();
            _currentUser = user;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = Name.Text;
            string category = Category.Text;
            string Opisanie = opisanie.Text;
            DateTime date = DP.SelectedDate ?? DateTime.Now;
            DateTime time = DateTime.Now;
            bool status = false;


            if (TR.NewTask(_currentUser, name, category, Opisanie, time, date, status))
            {


                MessageBox.Show("Задача успешно создана!");

                main main = new main(_currentUser);
                main.Show();
                this.Owner?.Close(); // Main_empty
                this.Close();

            }
        }
    }
}
