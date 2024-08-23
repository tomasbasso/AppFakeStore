using AppFakeStore.Views;
using CommunityToolkit.Mvvm.Input;

namespace AppFakeStore.ViewModels;

public partial class MainViewModel : BaseViewModel
{
    public MainViewModel()
    {
       this.Title = ""; // Eliminar título de la barra superior
    }

    [RelayCommand]
    public async Task GoToProductoLista()
    {
        // Mostrar la animación de carga
        await Application.Current.MainPage.Navigation.PushAsync(new ProductoListaPage());
    }

    [RelayCommand]
    public async Task GoToAcerca()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new AcercaPage());
    }

    [RelayCommand]
    public async Task Exit()
    {
        await Application.Current.MainPage.DisplayAlert("Salir", "¿Desea terminar la sesión y salir?", "Aceptar");
    }
}
