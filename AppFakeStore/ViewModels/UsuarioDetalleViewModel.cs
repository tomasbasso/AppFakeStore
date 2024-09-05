using AppFakeStore.Models;
using AppFakeStore.Utils;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppFakeStore.ViewModels;
public partial class UsuarioDetalleViewModel : BaseViewModel
{
    [ObservableProperty]
    Usuarios usuario;

    public UsuarioDetalleViewModel()
    {
        Title = "Detalle de Usuario";
    }

    [RelayCommand]
    private async Task GoBack()
    {
        await Application.Current.MainPage.Navigation.PopAsync();
    }


}
