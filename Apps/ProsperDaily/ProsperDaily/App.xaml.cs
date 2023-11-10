using ProsperDaily.MVVM.Models;
using ProsperDaily.MVVM.Views;
using ProsperDaily.Repositories;

namespace ProsperDaily;

public partial class App : Application
{

	 public static BaseRepository<Transaction>
		  TransactionsRepo{get;private set;}

	public App(BaseRepository<Transaction> _transcationsRepo)
	{
		InitializeComponent();

		  TransactionsRepo = _transcationsRepo;

		MainPage = new AppContainer();
	}
}
