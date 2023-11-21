using SQLite;
using SQLITEDemo.MVVM.Models;
using SQLITEDemo.MVVM.Views;
using SQLITEDemo.Repositories;

namespace SQLITEDemo;

public partial class App : Application
{
	SQLiteConnection connection;

	//public static CustomerRepository CustomerRepo { get; private set; }
	public static BaseRepository<Customer> CustomerRepo { get; private set; }
     public static BaseRepository<Order> OrdersRepo { get; private set; }
     public static BaseRepository<Passport> PassportsRepo { get; private set; }

	public App(BaseRepository<Customer> repo, 
		   BaseRepository<Order> ordersRepo,
           BaseRepository<Passport> passportsRepo)
	{
		InitializeComponent();

		  CustomerRepo = repo;
		  OrdersRepo = ordersRepo;
		  PassportsRepo = passportsRepo;

		#region n - n -->>>
			connection = new SQLiteConnection(Constants.DatabasePath,
						  Constants.Flags);
			connection.CreateTable<CustomerPassport>();
		#endregion

		MainPage = new MainPage();
	}
}
