using MVVMDemo.MVVM.Models;

namespace MVVMDemo.MVVM.ViewModels
{
    public class PersonViewModel
     {
          public Person Person { get; set; }
          public PersonViewModel()
          {
               Person = new Person
               {
                    Name = "Héctor",
                    Age = 50,
                    Married = true,
                    BirthDate = new DateTime(2000, 08, 05),
                    Weight = 100,
                    Lunchtime = new TimeSpan(10, 0, 0)
               };

          }
     }
}
