using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Styling;

namespace verstka_soboleva;

public partial class settingsPage : UserControl
{
    public settingsPage()
    {
        InitializeComponent();
    }
    private void ThemeToggle_Click(object? sender, RoutedEventArgs e)
    {
        if (Application.Current == null) return;

        Application.Current.RequestedThemeVariant = ThemeToggle.IsChecked == true ? ThemeVariant.Dark : ThemeVariant.Light;
    }
}