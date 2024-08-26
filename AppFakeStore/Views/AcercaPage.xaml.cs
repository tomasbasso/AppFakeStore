using Microsoft.Maui.Controls;
using System;

namespace AplicacionMovil.Views
{
    public partial class AcercaDePage : ContentPage
    {
        public AcercaDePage()
        {
            InitializeComponent();
        }

        private async void OnEmailButtonClicked(object sender, EventArgs e)
        {
            try
            {
                var message = new EmailMessage
                {
                    Subject = "Consulta",
                    Body = "",
                    To = new List<string> { "tomas.basso@hotmail.com" }
                };
                await Email.ComposeAsync(message);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"No se pudo abrir la aplicación de correo: {ex.Message}", "OK");

            }
        }
        private async void OnPhoneButtonClicked(object sender, EventArgs e)
        {
            try
            {
                var phoneNumber = new Uri("tel:+5492302524872"); // Reemplaza con tu número de contacto
                await Launcher.OpenAsync(phoneNumber);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"No se pudo iniciar la llamada: {ex.Message}", "OK");
            }
        }
    }
}
