using System.Collections.Generic;
using System.Threading.Tasks;
using AppFakeStore.Models;

namespace AppFakeStore.Services
{
    public interface IUsuariosService
    {
        Task<List<Usuarios>> ObtenerUsuariosAsync();
    }
}
