using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System;
using verstka_soboleva.Models;
using verstka_soboleva.Views;

namespace verstka_soboleva;

public partial class LoginWindow : Window
{
    public LoginWindow()
    {
        InitializeComponent();
    }
    private async void LogInClick(object? sender, RoutedEventArgs e)
    {
        ErrorTb.IsVisible = false;

        var username = LoginTb.Text?.Trim();
        var password = PasswordTb.Text;

        if (string.IsNullOrWhiteSpace(username))
        {
            ShowError("Введите логин");
            LoginTb.Focus();
            return;
        }

        if (string.IsNullOrWhiteSpace(password))
        {
            ShowError("Введите пароль");
            PasswordTb.Focus();
            return;
        }

        try
        {
            if (username != null && password != null)
            {
                if ((username == "admin" || username == "Admin") && password == "123456")
                {
                    ContextData.CurrentUser = new ViewModels.MainWindowViewModel.User
                    {
                        Name = "Ангелина Соболева",
                        Group = "420П",
                        Role = "Админ",
                        Description = "Описание описание лорем ипсум..."
                    };

                }
                else
                {
                    ContextData.CurrentUser = new ViewModels.MainWindowViewModel.User
                    {
                        Name = "Неизвестный",
                        Group = "Неизвестно",
                        Role = "Неизвестно",
                        Description = "Неизвестно"
                    };
                }
                    var mainWindow = new MainWindow();
                mainWindow.Show();

                Close();
            }

        }
        catch (Exception)
        {
            ShowError("Неверные входные данные");
        }
    }

    private void ShowError(string message)
    {
        ErrorTb.Text = message;
        ErrorTb.IsVisible = true;
    }
}