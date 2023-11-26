
using CommunityToolkit.Mvvm.ComponentModel;

namespace MVVMToolkitSample.MVVM.Models
{

     public partial class FakePerson : ObservableObject
     {
          [ObservableProperty]
          [NotifyPropertyChangedFor(nameof(FullName))]
          private string firstName;

          [ObservableProperty]
          private string _lastName;

          public string FullName
          {
               get
               {
                    return $"{FirstName} {LastName}";
               }
          }

        partial void OnFirstNameChanged(string value)
        {
               Console.WriteLine(value);
        }
    }
}