using NavegationDemo.MVVM.Pages;

namespace NavegationDemo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new StartPage());
	}
}
