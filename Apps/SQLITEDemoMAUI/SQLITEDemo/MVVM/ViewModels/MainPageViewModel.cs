using Bogus;
using PropertyChanged;
using SQLITEDemo.MVVM.Models;
using System.Windows.Input;

namespace SQLITEDemo.MVVM.ViewModels
{
	[AddINotifyPropertyChangedInterface]
     public class MainPageViewModel
     {
          public List<Customer> Customers { get; set; }
          public Customer CurrentCustomer { get; set; }

          public ICommand AddOrUpdateCommand { get; set; }
          public ICommand DeleteCommand { get; set; }
        
          public MainPageViewModel()
          {
               var orders = App.OrdersRepo.GetItems();
               Refresh();
               GenerateNewCustomer();

               AddOrUpdateCommand = new Command(async () =>
               {
                    //App.CustomerRepo.SaveItem(CurrentCustomer);
                    App.CustomerRepo.SaveItemWithChildren(CurrentCustomer);
                    Console.WriteLine(App.CustomerRepo.StatusMessage);
                    GenerateNewCustomer();
                    Refresh();
               });

               DeleteCommand = new Command(() =>
               {
                    App.CustomerRepo.DeleteItem(CurrentCustomer);
                    Refresh();
               });
          }

        private void GenerateNewCustomer()
        {
            CurrentCustomer = new Faker<Customer>()
                 .RuleFor(x => x.Name, f => f.Person.FullName)
                 .RuleFor(x => x.Address, f => f.Person.Address.Street)
                 .Generate();

			#region 1 to 1
			    // CurrentCustomer.Passport = new Passport()
			    // {
			    //   ExpirationDate =  DateTime.Now.AddDays(30),				
			    // };
			#endregion

			#region 1 to Many, Many to Many
			    //CurrentCustomer.Passport = new List<Passport>
			    //   	   {
			    //   			new Passport
			    //			{
			    //				 ExpirationDate =
			    //					  DateTime.Now.AddDays(30)
			    //   			},
			    //   			new Passport
			    //			{
			    //				 ExpirationDate =
			    //					  DateTime.Now.AddDays(15)
			    //   			},
			    //   	   };
			#endregion

			#region  n - n -->>>
			    CurrentCustomer.Passports = new List<Passport>
			    {
					    new Passport
					    {
						     ExpirationDate =
							      DateTime.Now.AddDays(30)
					    },
					    new Passport
					    {
						     ExpirationDate =
							      DateTime.Now.AddDays(15)
					    },
			    };
			#endregion
		}
		private void Refresh()
          {
               //Customers = App.CustomerRepo.GetItems();
               Customers = App.CustomerRepo.GetItemsWithChildren();
               //Customers = App.CustomerRepo.GetAll(x => x.Name.StartsWith("A"));
               var passports =
                    App.PassportsRepo.GetItems();
          }
     }
}
