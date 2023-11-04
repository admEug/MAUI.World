﻿namespace CodeQuotes;

public partial class MainPage : ContentPage
{
     List<string> quotes =
          new List<string>();
	public MainPage()
	{
		InitializeComponent();
	}

     protected override async void OnAppearing()
     {
          base.OnAppearing();
          await LoadMauiAsset();
     }

     async Task LoadMauiAsset()
     {
          using var stream = await FileSystem.OpenAppPackageFileAsync("quotes.txt");
          using var reader = new StreamReader(stream);

          while(reader.Peek() !=-1)
          {
               quotes.Add(reader.ReadLine());
          }
     }

     Random random = new Random();
     private void btnGenerateQuote_Clicked(object sender, EventArgs e)
     {
          var startColor =
               System.Drawing.Color.FromArgb(
                    random.Next(0, 256),
                    random.Next(0, 256),
                    random.Next(0, 256));

          var endColor =
               System.Drawing.Color.FromArgb(
                    random.Next(0, 256),
                    random.Next(0, 256),
                    random.Next(0, 256));


          var colors =
            ColorUtility
            .ColorControls
            .GetColorGradient(startColor, endColor, 6);

          float stopOffset = .0f;
          var stops = new GradientStopCollection();
          foreach(var c in colors)
          {
               stops.Add(new GradientStop(Color.FromArgb(c.Name),
                    stopOffset));
               stopOffset += .2f;
          }

          var gradient =
               new LinearGradientBrush(stops,
                    new Point(0, 0),
                    new Point(1, 1));

          background.Background = gradient;

          int index = random.Next(quotes.Count);
          quote.Text = quotes[index];
     }
}

