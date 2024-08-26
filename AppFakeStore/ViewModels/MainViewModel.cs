using AplicacionMovil.Views;
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
        await Application.Current.MainPage.Navigation.PushAsync(new ProductoListaPage());
    }

    [RelayCommand]
    public async Task GoToAcerca()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new AcercaDePage());
    }

    // Agregar el atributo RelayCommand aquí
    [RelayCommand]
    public async Task GoToUsuarios()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new UsuarioView());
    }

    [RelayCommand]
    public async Task Exit()
    {
        await OnSalirButtonClicked();
    }

    private async Task OnSalirButtonClicked()
    {
        bool respuesta = await Application.Current.MainPage.DisplayAlert("Salir", "¿Desea terminar la sesión y salir?", "Aceptar", "Cancelar");

        if (respuesta)
        {
            Application.Current.MainPage = new NavigationPage(new LoginView());
        }
    }
}
