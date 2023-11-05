using NavegationDemo.Utilities;

namespace NavegationDemo.MVVM.Pages;

public partial class FinalPage : ContentPage
{
	public FinalPage()
	{
		InitializeComponent();
	}

     protected override void OnAppearing()
     {
          base.OnAppearing();
          NavUtilities.Examine(Navigation);
     }

     private void Button_Clicked(object sender, EventArgs e)
     {
		  Navigation.PopAsync();
     }

     private void Button_Clicked_1(object sender, EventArgs e)
     {
          //Navigation.PopToRootAsync();
          NavUtilities.InsertPage(Navigation);
     }
}