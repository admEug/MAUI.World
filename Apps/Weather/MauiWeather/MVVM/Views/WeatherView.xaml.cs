using MauiWeather.MVVM.ViewModels;

namespace MauiWeather.MVVM.Views;

public partial class WeatherView : ContentPage
{
	public WeatherView()
	{
		InitializeComponent();
		  BindingContext = new WeatherViewModel();
	}
}