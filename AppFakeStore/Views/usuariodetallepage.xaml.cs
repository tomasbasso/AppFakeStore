using AppFakeStore.Models;

namespace AppFakeStore.Views
{
    public partial class usuariodetallepage : ContentPage
    {
        public usuariodetallepage(Usuarios selectedUser)
        {
            InitializeComponent();
            BindingContext = selectedUser; // Establece el blinding al usuario seleccionado
        }
    }
}