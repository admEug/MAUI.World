using FruitDemo.Models;

namespace FruitDemo;

public partial class MainPage : ContentPage
{	
	 public List<FruitInformation> PapayaInfo { get; set; }
	public MainPage()
	{
		InitializeComponent();
          PapayaInfo = new List<FruitInformation>
          {
               new FruitInformation
               {
                    Micronutrient = "Vitamin C",
                    Percentage = 101
               },
               new FruitInformation
               {
                    Micronutrient = "Vitamin A",
                    Percentage = 19
               },
               new FruitInformation
               {
                    Micronutrient = "Calcium",
                    Percentage = 2
               },
               new FruitInformation
               {
                    Micronutrient = "Magnesium",
                    Percentage = 5
               },
               new FruitInformation
               {
                    Micronutrient = "Potassium",
                    Percentage = 5
               },
          };
          this.BindingContext = this;
     }

}

