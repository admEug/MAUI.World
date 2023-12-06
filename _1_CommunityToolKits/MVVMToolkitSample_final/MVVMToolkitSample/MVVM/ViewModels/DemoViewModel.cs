using Bogus;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVMToolkitSample.MVVM.Models;

namespace MVVMToolkitSample.MVVM.ViewModels
{
     public partial class DemoViewModel : ObservableObject
     {
          [ObservableProperty]
          private string password;

          public FakePerson Person { get; set; }

          [RelayCommand]
          async Task GenerateData(string demo)
          {
               var faker = new Faker<FakePerson>()
                    .RuleFor(p => p.FirstName, f => f.Person.FirstName)
                    .RuleFor(p => p.LastName, f => f.Person.LastName)
                    .Generate();

               Person.FirstName = faker.FirstName;
               Person.LastName = faker.LastName;

               Password = new Faker().Internet.Password(5, true);
          }        

          public DemoViewModel()
          {
               Person = new FakePerson
               {
                    FirstName = "Héctor",
                    LastName = "Pérez",
               };

               Password = new Faker().Internet.Password(5, true);
          }
     }
}
