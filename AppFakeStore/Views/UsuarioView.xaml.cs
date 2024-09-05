using AppFakeStore.Models;
using AppFakeStore.ViewModels;
using AppFakeStore.Views; 

namespace AppFakeStore.Views
{
    public partial class UsuarioView : ContentPage
    {
        public UsuarioView()
        {
            InitializeComponent();
            BindingContext = new UsuarioListaViewModel(Navigation);
        }

        private async void OnSelectionChanged(object sender, SelectionChangedEventArgs seleccion)
        {
            try
            {
                if (seleccion.CurrentSelection != null && seleccion.CurrentSelection.Count > 0)//compar
                {
                    // Obtiene el usuario seleccionado
                    var usuario_seleccionado = seleccion.CurrentSelection[0] as Usuarios;

                    // Navegar a la página de detalles del usuario
                    await Navigation.PushAsync(new usuariodetallepage(usuario_seleccionado));

                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
