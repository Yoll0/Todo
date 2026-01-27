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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf
{
    /// <summary>
    /// Логика взаимодействия для main_empty_p_.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        private UserModel _currentUser;

        public MainPage(UserModel user)
        {
            InitializeComponent();
            _currentUser = user;
            Nick.Content = user.Login;
            Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            // Инициализация после загрузки, если нужно
        }

        private void profileImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
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
            // Ваш код для изменения фото профиля
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService != null)
            {
                NavigationService.Navigate(new MainWindow()); 
            }
            else
            {
                // Или создаем новое главное окно
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();

                // Закрываем текущее окно
                var window = Window.GetWindow(this);
                if (window != null)
                {
                    window.Close();
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Для диалогового окна нужно получить родительское окно
            var parentWindow = Window.GetWindow(this);

            AddTaskDialog addTaskDialog = new AddTaskDialog(_currentUser);
            addTaskDialog.Owner = parentWindow;
            addTaskDialog.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            addTaskDialog.ShowDialog();
        }

        // Дополнительные методы для навигации между страницами
        private void NavigateToPage(Page page)
        {
            if (NavigationService != null)
            {
                NavigationService.Navigate(page);
            }
            else
            {
                // Альтернатива: изменение содержимого окна
                var window = Window.GetWindow(this);
                if (window != null)
                {
                    window.Content = page;
                }
            }
        }
    }
}
