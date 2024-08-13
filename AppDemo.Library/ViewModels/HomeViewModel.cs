using CommunityToolkit.Mvvm.ComponentModel;

namespace AppDemo.Library.ViewModels;

public partial class HomeViewModel : ObservableRecipient
{
    [ObservableProperty]
    private string message;
}
