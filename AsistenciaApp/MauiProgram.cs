using Microsoft.Extensions.Logging;

namespace AsistenciaApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("nexa-black.otf", "nblack");
                fonts.AddFont("Stovia-SemiBold.ttf", "SemiBold");
                fonts.AddFont("Font Awesome 6 Free-Solid-900.otf", "AwesomeSolid");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
