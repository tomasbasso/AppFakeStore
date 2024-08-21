using AppFakeStore.ViewModels;

namespace AppFakeStore
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();

            MainViewModel viewModel = new MainViewModel();
            this.BindingContext = viewModel;
        }
        
    }

}
