using CommunityToolkit.Mvvm.ComponentModel;

namespace AppDemo.Library.ViewModels;

public partial class TitleViewModel : ObservableRecipient
{
    [ObservableProperty]
    private string title;

    public TitleViewModel()
    {
        Title = "Hello world";
    }
}
