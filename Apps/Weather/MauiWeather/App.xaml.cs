using MauiWeather.MVVM.Views;

namespace MauiWeather;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new WeatherView();
	}
}
