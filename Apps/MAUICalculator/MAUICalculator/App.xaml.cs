using MAUICalculator.MVVM;

namespace MAUICalculator;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new CalcView();
	}
}
