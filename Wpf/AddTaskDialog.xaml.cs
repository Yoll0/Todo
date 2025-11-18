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
        private bool _isNewMainWindow = false;
        string category;

        public AddTaskDialog(UserModel user, bool isNewMainWindow = false)
        {
            InitializeComponent();
            _currentUser = user;
            _isNewMainWindow = isNewMainWindow;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                       string name;
            if (string.IsNullOrEmpty(Name.Text))
            {
                return;
            }
            else
            {
                name = Name.Text;
            }

            if (category == null)
            {
                MessageBox.Show("Выберите категорию");
                return;
            }

            string Opisanie = opisanie.Text;
            DateTime date = DP.SelectedDate ?? DateTime.Now;
            DateTime time = DateTime.Now;
            bool status = false;

            if (TR.NewTask(_currentUser, name, category, Opisanie, time, date, status))
            {
                MessageBox.Show("Задача успешно создана!");

                if (_isNewMainWindow)
                {
                    
                    main main = new main(_currentUser);
                    main.Show();
                    this.Owner?.Close(); 
                }
                else
                {
                    if (this.Owner is main mainWindow)
                    {
                        mainWindow.TasksList.ItemsSource = null;
                        mainWindow.TasksList.ItemsSource = _currentUser.UTasks;
                    }
                }

                this.Close();
            }
        }

        private void Category_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Category.SelectedItem is ComboBoxItem selectedItem)
            {
                category = selectedItem.Tag.ToString();
            }
        }
    }
}
