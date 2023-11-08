using SkiaSharp.Views.Maui.Controls.Hosting;

namespace MauiWeather;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseSkiaSharp()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                 fonts.AddFont("Rubik-Light.ttf", "RubikLight");
                 fonts.AddFont("Rubik-Regular.ttf", "Rubik");
            });

		return builder.Build();
	}
}
