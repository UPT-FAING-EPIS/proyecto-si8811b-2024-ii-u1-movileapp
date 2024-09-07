namespace AsistenciaApp.Views
{
    public partial class LoginView : ContentPage
    {
        private const string codigo = "2019063331";
        private const string contrase�a = "123456";

        public LoginView()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string LogCodigo = ((Entry)this.FindByName("EntryCodigo")).Text;
            string LogContra = ((Entry)this.FindByName("EntryPassword")).Text;

            if (LogCodigo == codigo && LogContra == contrase�a)
            {
                
                await DisplayAlert("Login", "Login exitoso", "OK");

                
                await Navigation.PushAsync(new MainView());
            }
            else
            {
                
                await DisplayAlert("Login", "C�digo o contrase�a incorrectos", "OK");
            }
        }
    }
}
