using AsistenciaApp.Views;

namespace AsistenciaApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MainPage = new NavigationPage(new LoginView());


    }


}
