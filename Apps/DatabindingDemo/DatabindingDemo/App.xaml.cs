using DatabindingDemo.Pages;

namespace DatabindingDemo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new MainPage();
	}
}
