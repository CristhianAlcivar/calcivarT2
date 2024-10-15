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
        string contraseña = txtContraseña.Text;

        if (usuario == "admin" && contraseña == "1234")
        {
            await Navigation.PushAsync(new VHome());
        }
        else
        {
            await DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
        }
    }
}