namespace aburbanoExamen.Views;

public partial class vLogin : ContentPage
{
	public vLogin()
	{
		InitializeComponent();
       
	}
    private readonly string[] user = { "estudiante2025", "uisrael", "sistemas" };
    private readonly string[] pass = { "moviles", "2025", "2025_1" };

    private void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string contraseña = txtContraseña.Text;

        if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
        {
            DisplayAlert("Error", "Por favor ingrese usuario y contraseña", "Aceptar");
        }

        int ingreso = Array.IndexOf(user, usuario);
        if (ingreso != -1 && pass[ingreso] == contraseña)
        {
            Navigation.PushAsync(new Views.vRegistro(usuario));
        }
        else
        {
            DisplayAlert("Error", "Usuario o contraseña incorrectos.", "Aceptar");
        }

    }


    private void btnAcerca_Clicked(object sender, EventArgs e)
    {

    }