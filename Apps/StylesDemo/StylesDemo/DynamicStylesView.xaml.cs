namespace StylesDemo;

public partial class DynamicStylesView : ContentPage
{
	public DynamicStylesView()
	{
		InitializeComponent();
	}

	 private void Button_Clicked(object sender, EventArgs e)
	 {
		// From a resource file
		Application.Current
			 .Resources.TryGetValue("specialButton",
				  out var retVal);

		Resources["dynamicStyle"] =
			 (Style)retVal;

		// from the same class
		//Resources["dynamicStyle"] = Resources["greenStyle"];
	 }
}