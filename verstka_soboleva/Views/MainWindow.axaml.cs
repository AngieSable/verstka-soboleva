using Avalonia.Controls;
using verstka_soboleva.Models;
using verstka_soboleva.ViewModels;

namespace verstka_soboleva.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainContentControl.Content = new reviewPage();
            DataContext = new MainWindowViewModel();
        }

        private void review_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            MainContentControl.Content = new reviewPage();
        }
        private void projects_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            MainContentControl.Content = new projectsPage();
        }
        private void tasks_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            MainContentControl.Content = new tasksPage();
        }
        private void calendar_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            MainContentControl.Content = new calendarPage();
        }
        private void team_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            MainContentControl.Content = new teamPage();
        }
        private void settings_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            MainContentControl.Content = new settingsPage();
        }
        private void profile_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            MainContentControl.Content = new profilePage();
        }
        private void logout_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            ContextData.CurrentUser = null;

            var loginWindow = new LoginWindow();
            loginWindow.Show();

            Close();
        }
    }
}