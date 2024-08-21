using CommunityToolkit.Mvvm.ComponentModel;

namespace AppFakeStore.ViewModels;

public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    private bool isBusy;  

    [ObservableProperty]
    private string title;
}
