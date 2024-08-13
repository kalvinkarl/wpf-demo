using AppDemo.Library.ViewModels;
using AppDemo.Views;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using System.Windows.Automation.Provider;

namespace AppDemo.Helpers;

public static class AppHelper
{
    public static ServiceProvider StartBuild(this ServiceCollection service)
    {
        return service.AddTransient<AppRoot>()
            .AddTransient<HomeViewModel>()
            .AddTransient<Home>()
            .AddTransient<TitleViewModel>()
            .AddTransient<Title>()
            .BuildServiceProvider();
    }
    public static async Task Activate(this ServiceProvider provider)
    {
        var mainWindow = provider.GetRequiredService<AppRoot>();
        mainWindow.HomePage.Content = provider.GetRequiredService<Home>();
        mainWindow.TitlePage.Content = provider.GetRequiredService<Title>();
        mainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        mainWindow.WindowStyle = WindowStyle.None;
        mainWindow.Show();
        await Task.CompletedTask;
    }
}
