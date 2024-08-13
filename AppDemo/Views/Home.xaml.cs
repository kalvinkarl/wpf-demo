using AppDemo.Library.ViewModels;
using System.Windows.Controls;

namespace AppDemo.Views;

public partial class Home : Page
{
    public Home(HomeViewModel vm)
    {
        InitializeComponent();
        DataContext = vm;
    }
}
