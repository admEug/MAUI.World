using DatabindingDemo.Models;
using System.ComponentModel;

namespace DatabindingDemo;

public partial class MainPage : ContentPage
{
	 Person person = new Person();

	public MainPage()
	{
		InitializeComponent();

          person = new Person
          {
               Name = "John",
               Phone = "9999",
               Address = "X Address"
          };

          BindingContext = person;
     }

     private void OnCounterClicked(object sender, EventArgs e)
     {
        person.Name = "Peter";
        person.Phone = "0000";
        person.Address = "New Address";

        //person = new Person
        //{
        //     Name = "Peter 1",
        //     Phone = "0000 _ - - - _",
        //     Address = "New Address"
        //};

        // txtName.BindingContext = person;
        // txtName.SetBinding(Label.TextProperty, "Name");

        //Binding personBinding =
        //  new Binding();

        //personBinding.Source = person;
        //personBinding.Path = "Name";

        //txtName.SetBinding(Label.TextProperty, personBinding);


    }
}

