using AppDemo.Helpers;
using AppDemo.Views;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace AppDemo;

public partial class App : Application
{
    protected override async void OnStartup(StartupEventArgs e)
    {
        await new ServiceCollection().StartBuild().Activate();
        base.OnStartup(e);
    }
}
