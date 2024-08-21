namespace AppFakeStore.Views;

public partial class AcercaPage : ContentPage
{
	public AcercaPage()
	{
		InitializeComponent();
	}    

    private void IconBtn_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage.DisplayAlert("Aviso", "Mostramos mensaje Alternativo!", "Aceptar");
    }

    private void BackBtn_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.PopAsync();
    }
}