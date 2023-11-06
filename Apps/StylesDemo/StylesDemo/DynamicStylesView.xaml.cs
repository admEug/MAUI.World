namespace StylesDemo;

public partial class DynamicStylesView : ContentPage
{
	public DynamicStylesView()
	{
		InitializeComponent();
	}

	 private void Button_Clicked(object sender, EventArgs e)
	 {

		  Application.Current
			   .Resources.TryGetValue("specialButton",
					out var retVal);

		  Resources["dynamicStyle"] =
			   (Style)retVal;
	 }
}