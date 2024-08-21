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
                UsernameEntry.Text = "";
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
                PasswordEntry.Text = "***********";
            }
        }
        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;

            var viewModel = new LoginViewModel();
            bool success = await viewModel.Login(username, password);

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

    }
}
