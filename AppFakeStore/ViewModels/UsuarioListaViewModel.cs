using System.Collections.ObjectModel;
using System.Threading.Tasks;
using AppFakeStore.Models;
using AppFakeStore.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AppFakeStore.ViewModels
{
    public class UsuarioListaViewModel : ObservableObject
    {
        private readonly IUsuariosService _usuariosService;//serivicio para traer la lista

        public ObservableCollection<Usuarios> Usuarios { get; set; } = new ObservableCollection<Usuarios>();


        //PROPIEDAD DEL INDICADOR DE CARGA
        private bool _isLoading;
        public bool IsLoading
        {
            get => _isLoading;
            set => SetProperty(ref _isLoading, value);
        }

        private bool _isDataLoaded;
        public bool IsDataLoaded
        {
            get => _isDataLoaded;
            set => SetProperty(ref _isDataLoaded, value);//ACTUALIZA VALOR
        }
       
        /// ///////////////////////////////////////////////
      
        public UsuarioListaViewModel()
        {
            _usuariosService = new UsuariosService();
            _ = CargarUsuarios(); //_ = permite llamar al método asincrónico sin necesidad de esperar su resultado explícitamente
        }

        private async Task CargarUsuarios()
        {
            IsLoading = true;//datos en carga
            IsDataLoaded = false;

            var usuarios = await _usuariosService.ObtenerUsuariosAsync();// obtengo  lista de usuarios
            Usuarios.Clear();
            foreach (var usuario in usuarios)
            {
                Usuarios.Add(usuario);//Agrega los c/u de los usuarios 
            }

            IsLoading = false;
            IsDataLoaded = true; //Se establece cargadp
        }
    }
}
