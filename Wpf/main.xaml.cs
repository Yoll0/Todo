using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Wpf
{
    /// <summary>
    /// Логика взаимодействия для main.xaml
    /// </summary>
    public partial class main : Window, INotifyPropertyChanged
    {
        private UserModel _currentUser;
        private TaskModel _selectedTask;

        public TaskModel SelectedTask
        {
            get => _selectedTask;
            set
            {
                _selectedTask = value;
                OnPropertyChanged();
            }
        }

        public main(UserModel user)
        {
            InitializeComponent();
            _currentUser = user;
            TasksList.ItemsSource = _currentUser.UTasks;
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void TasksListView_SelectionChanged_1(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            SelectedTask = TasksList.SelectedItem as TaskModel;
        }

        private void AddTask(object sender, RoutedEventArgs e)
        {
            AddTaskDialog addTaskDialog = new AddTaskDialog(_currentUser, false);
            addTaskDialog.Owner = this;
            addTaskDialog.ShowDialog();
        }

        private void HomeCl(object sender, RoutedEventArgs e)
        {
            var homeTasks = _currentUser.UTasks.Where(t => t.Category == "Home").ToList();
            TasksList.ItemsSource = homeTasks;
        }

        private void WorkCl(object sender, RoutedEventArgs e)
        {
            var workTasks = _currentUser.UTasks.Where(t => t.Category == "Work").ToList();
            TasksList.ItemsSource = workTasks;
        }

        private void StudyCl(object sender, RoutedEventArgs e)
        {
            var StudyTasks = _currentUser.UTasks.Where(t => t.Category == "Study").ToList();
            TasksList.ItemsSource = StudyTasks;
        }

        private void RestCl(object sender, RoutedEventArgs e)
        {
            var OtdixTasks = _currentUser.UTasks.Where(t => t.Category == "Leisure").ToList();
            TasksList.ItemsSource = OtdixTasks;
        }

        private void TaskList(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var TaskList = _currentUser.UTasks.Where(t => t.Status == false).ToList();
            TasksList.ItemsSource = TaskList;
        }

        private void EndedTasks(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var EndedTasks = _currentUser.UTasks.Where(t => t.Status == true).ToList();
            TasksList.ItemsSource = EndedTasks;
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            _currentUser.UTasks.Remove(SelectedTask);
            RefreshTasks();
        }

        private void Compleated_Click(object sender, RoutedEventArgs e)
        {
            SelectedTask.Status = true;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public void RefreshTasks()
        {
            TasksList.ItemsSource = null;
            TasksList.ItemsSource = _currentUser.UTasks;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {

        }
    }
}
