using AppFakeStore.Models;
using AppFakeStore.ViewModels;
using AppFakeStore.Views; // Asegúrate de importar el namespace correcto

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
                if (seleccion.CurrentSelection != null && seleccion.CurrentSelection.Count > 0)//comparo que tenga contenido
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
