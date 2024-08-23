using AppFakeStore.Services;
using AppFakeStore.ViewModels;

namespace AppFakeStore.Views;

public partial class ProductoListaPage : ContentPage
{
	public ProductoListaPage()
	{
		ProductoService service = new ProductoService();
		ProductoListaViewModel vm = new ProductoListaViewModel(service);
		InitializeComponent();
		this.BindingContext = vm;
	}

	protected async override void OnAppearing()
	{
		base.OnAppearing();

		var vm = BindingContext as ProductoListaViewModel;

		if (vm != null)
		{
            // Mostrar la animación de carga
            LoadingIndicator.IsRunning = true;
            LoadingIndicator.IsVisible = true;

          
            await vm.GetProductosCommand.ExecuteAsync(null);
        } else
		 
    {
            // Ocultar la animación de carga
            LoadingIndicator.IsRunning = false;
            LoadingIndicator.IsVisible = false;
        }
    }
}