namespace calcivarT2.Views;

public partial class VLogin : ContentPage
{
	public VLogin()
	{
		InitializeComponent();
	}
    private async void OnLoginClicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string contrase�a = txtContrase�a.Text;

        if (usuario == "admin" && contrase�a == "1234")
        {
            await Navigation.PushAsync(new VHome());
        }
        else
        {
            await DisplayAlert("Error", "Usuario o contrase�a incorrectos", "OK");
        }
    }
}