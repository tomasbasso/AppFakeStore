using System;
using Microsoft.Maui.Controls;

namespace AppFakeStore.Views
{
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();

        }
        //Propiedad visuales para borrar datos en caso de que esten mal
        private void UsernameEntry_Focused(object sender, FocusEventArgs e)
        {
            if (UsernameEntry.Text == "Usuario")
            {
                UsernameEntry.Text = string.Empty;
            }
        }

        private void UsernameEntry_Unfocused(object sender, FocusEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameEntry.Text))
            {
                UsernameEntry.Text = "Usuario"; // Reestablece el texto por defecto si está vacío
            }
        }

        private void PasswordEntry_Focused(object sender, FocusEventArgs e)
        {
            if (PasswordEntry.Text == "***********")
            {
                PasswordEntry.Text = string.Empty;
            }
        }

        private void PasswordEntry_Unfocused(object sender, FocusEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordEntry.Text))
            {
                PasswordEntry.Text = "***********"; // Reestablece el texto por defecto si está vacío
            }
        }
        
        /// ///////////////////////////////////////////////////////////////////////////////////
       
        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            // Mostrar la animación de carga
            LoadingIndicator.IsRunning = true;
            LoadingIndicator.IsVisible = true;

            await Task.Delay(500); // retraso para ver inidicador

            try
            {
                string username = UsernameEntry.Text;
                string password = PasswordEntry.Text;

                var viewModel = new LoginViewModel();
                bool success = await viewModel.Login(username, password); //compara con el login , si es correcto entra

                if (success)
                {
                    // Navegar a MainPage
                    await Navigation.PushAsync(new MainPage());
                }
                else
                {
                    // Mostrar mensaje de error
                    await DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
                }
            }
            catch (Exception ex)
            {
                // Manejar posibles excepciones
                await DisplayAlert("Error", $"Ocurrió un error: {ex.Message}", "OK");
            }
            finally
            {
                // Ocultar la animación de carga
                LoadingIndicator.IsRunning = false;
                LoadingIndicator.IsVisible = false;
            }
        }
    }
}