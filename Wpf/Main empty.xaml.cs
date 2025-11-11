using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Wpf
{
    /// <summary>
    /// Логика взаимодействия для Main_empty.xaml
    /// </summary>
    public partial class Main_empty : Window
    {
        private UserModel _currentUser;
        public Main_empty(UserModel user)
        {
            InitializeComponent();
            _currentUser = user;
            Nick.Content = user.Login;

        }
        private void profileImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
           // profilePopup.IsOpen = true;
            if (profilePopup.IsOpen)
            {
                profilePopup.IsOpen = false;
            }
            else
            {
                profilePopup.IsOpen = true;
            }
        }

        private void ChangeProfilePhoto_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            
            MainWindow mainWindow = new MainWindow ();
            mainWindow.Show();
            this.Close();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddTaskDialog addTaskDialog = new AddTaskDialog (_currentUser);
            addTaskDialog.Owner = this; 
            addTaskDialog.ShowDialog();
        }
    }
}
