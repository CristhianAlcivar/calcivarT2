namespace calcivarT2.Views;

public partial class VLogin : ContentPage
{
    private Dictionary<string, string> usuarios = new Dictionary<string, string>()
    {
        { "Carlos", "carlos123" },
        { "Ana", "ana123" },
        { "Jose", "jose123" }
    };
    public VLogin()
	{
		InitializeComponent();
	}
    private async void OnLoginClicked(object sender, EventArgs e)
    {
        string inputUsuario = txtUsuario.Text;
        string inputContrasena = txtContraseña.Text;

        if (usuarios.ContainsKey(inputUsuario))
        {
            string storedPassword = usuarios[inputUsuario];

            if (storedPassword == inputContrasena)
            {
                Navigation.PushAsync(new VHome());
            }
            else
            {
                DisplayAlert("Error", "Usuario o contraseña incorrecto", "OK");
            }
        }
        else
        {
            DisplayAlert("Error", "Usuario no registrado", "OK");
        }
    }
}