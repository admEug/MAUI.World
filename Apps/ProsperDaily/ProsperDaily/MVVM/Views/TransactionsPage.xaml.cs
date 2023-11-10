using ProsperDaily.MVVM.ViewModels;

namespace ProsperDaily.MVVM.Views;

public partial class TransactionsPage : ContentPage
{
	public TransactionsPage()
	{
		InitializeComponent();
		  BindingContext = new TransactionsViewModel();
	}

	 private async void Save_Clicked(object sender, EventArgs e)
	 {
		  var currentVM =
			   (TransactionsViewModel)BindingContext;
		  var message =
			   currentVM.SaveTransaction();
		  await DisplayAlert("Info", message, "Ok");
		  await Navigation.PopToRootAsync();
	 }

	 private async void Cancel_Clicked(object sender, EventArgs e)
	 {
          await Navigation.PopToRootAsync();
     }


}