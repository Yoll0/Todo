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
        public Main_empty()
        {
            InitializeComponent();
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
            profilePopup.IsOpen = false;
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            // Добавьте код для выхода из приложения
            profilePopup.IsOpen = false;
        }
    }
}
