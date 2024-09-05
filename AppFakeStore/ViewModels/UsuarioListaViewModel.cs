using System.Collections.ObjectModel;
using System.Threading.Tasks;
using AppFakeStore.Models;
using AppFakeStore.Services;
using AppFakeStore.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace AppFakeStore.ViewModels
{
    public partial class UsuarioListaViewModel : ObservableObject
    {
        private readonly IUsuariosService _usuariosService; // Servicio para traer la lista
        private readonly INavigation _navigation; // Navegación

        public ObservableCollection<Usuarios> Usuarios { get; set; } = new ObservableCollection<Usuarios>();

        // Propiedad del indicador de carga
        [ObservableProperty]
        private bool isLoading;

        [ObservableProperty]
        private bool isDataLoaded;

        public UsuarioListaViewModel()
        {
     
        }

        public UsuarioListaViewModel(INavigation navigation)
        {
            _usuariosService = new UsuariosService();
            _navigation = navigation;
            _ = CargarUsuarios(); // Cargar usuarios de forma asíncrona
        }

        private async Task CargarUsuarios()
        {
            IsLoading = true; // Datos en carga
            IsDataLoaded = false;

            var usuarios = await _usuariosService.ObtenerUsuariosAsync(); // Obtener lista de usuarios
            Usuarios.Clear();
            foreach (var usuario in usuarios)
            {
                Usuarios.Add(usuario); // Agregar usuarios a la colección
            }

            IsLoading = false;
            IsDataLoaded = true; // Datos cargados
        }

        // Comando de selección de usuario
  
        private async Task SeleccionarUsuario(Usuarios usuario)
        {
            if (usuario != null && _navigation != null)
            {
                // Navegar a la página de detalles del usuario
                await _navigation.PushAsync(new usuariodetallepage(usuario));
            }
        }
    }
}
