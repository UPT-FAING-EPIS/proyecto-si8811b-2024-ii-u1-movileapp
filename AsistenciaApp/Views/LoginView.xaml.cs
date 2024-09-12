using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using System;

namespace AsistenciaApp.Views
{
    public partial class LoginView : ContentPage
    {
        private const string codigo = "2019063331";
        private const string contraseña = "123456";

        public LoginView()
        {
            InitializeComponent();
            Shell.SetNavBarIsVisible(this, false);
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string LogCodigo = ((Entry)this.FindByName("EntryCodigo")).Text;
            string LogContra = ((Entry)this.FindByName("EntryPassword")).Text;

            if (string.IsNullOrWhiteSpace(LogCodigo) && string.IsNullOrWhiteSpace(LogContra))
            {
                await DisplayAlert("Advertencia", "No ha ingresado nada en Código/Contraseña", "OK");
                return;
            }

            if (LogCodigo == codigo && LogContra == contraseña)
            {
                await DisplayAlert("Login", "Login exitoso", "OK");
                await Navigation.PushAsync(new MainView());
            }
            else
            {
                await DisplayAlert("Login", "Código o contraseña incorrectos", "OK");
            }
        }
        //ENTRYS
        private async void OnEntryFocused(object sender, FocusEventArgs e)
        {
            var entry = sender as Entry;
            entry.BackgroundColor = Color.FromArgb("#D3D3D3"); // Cambia a gris claro
            await entry.ScaleTo(1.1, 100, Easing.CubicInOut);
        }

        private async void OnEntryUnfocused(object sender, FocusEventArgs e)
        {
            var entry = sender as Entry;
            entry.BackgroundColor = Color.FromArgb("#EDEBF6"); // Vuelve a su color original
            await entry.ScaleTo(1.0, 100, Easing.CubicInOut);
        }

        //BOTON
        private async void OnButtonPressed(object sender, EventArgs e)
        {
            var button = (Button)sender;
            await AnimatedButton.ScaleTo(1.1, 100); // Agranda el botón
        }

        private async void OnButtonReleased(object sender, EventArgs e)
        {
            var button = (Button)sender;
            await AnimatedButton.ScaleTo(1.0, 100); // Vuelve a su tamaño original
        }
    }
}
