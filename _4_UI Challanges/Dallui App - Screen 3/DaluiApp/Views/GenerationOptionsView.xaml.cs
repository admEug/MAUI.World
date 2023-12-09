using DaluiApp.Models;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;

namespace DaluiApp.Views;

public partial class GenerationOptionsView : ContentPage
{
     public List<string> Options { get; set; }
     public List<ArtStyle> Styles { get; set; }


     public GenerationOptionsView()
     {
          InitializeComponent();
          FillOptions();
          BindingContext = this;

          Microsoft.Maui.Handlers.EditorHandler.Mapper.AppendToMapping("MyCustomization", (handler, view) =>
          {
#if ANDROID

               handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToAndroid());
#elif IOS || MACCATALYST
         
#elif WINDOWS

#endif
          });
     }

     private void FillOptions()
     {
          Options = new List<string>
          {
               "World",
               "Winter",
               "Trees"
          };
          Styles = new List<ArtStyle>()
          {
               new ArtStyle() { Name = "Cartoon", ImageUrl = "cartoon.jpg" },
               new ArtStyle() { Name = "Realistic", ImageUrl = "realistic.jpg" },
               new ArtStyle() { Name = "Watercolor Art", ImageUrl = "watercolor.jpg" },
               new ArtStyle() { Name = "Isometric", ImageUrl = "isometric.jpg" },
               new ArtStyle() { Name = "Pop Art", ImageUrl = "popart.jpg" },
               new ArtStyle() { Name = "Surrealism", ImageUrl = "surrealism.jpg" },
               new ArtStyle() { Name = "Minimalism", ImageUrl = "minimalism.jpg" },
               new ArtStyle() { Name = "Funko", ImageUrl = "funko.jpg" },
               new ArtStyle() { Name = "Anime", ImageUrl = "anime.jpg" },
               new ArtStyle() { Name = "Storybook", ImageUrl = "storybook.jpg" },
          };
     }
}