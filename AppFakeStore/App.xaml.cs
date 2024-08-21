using AppFakeStore.Services;
using AppFakeStore.ViewModels;
using AppFakeStore.Views;

namespace AppFakeStore
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new LoginView());

        }
    }
}
