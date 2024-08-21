using AppFakeStore.Models;
using AppFakeStore.ViewModels;

namespace AppFakeStore.Views;

public partial class ProductoDetallePage : ContentPage
{
	public ProductoDetallePage(Producto param)
	{
		InitializeComponent();

		ProductoDetalleViewModel vm = new ProductoDetalleViewModel();
		this.BindingContext = vm;		
		vm.Producto = param;
	}
}