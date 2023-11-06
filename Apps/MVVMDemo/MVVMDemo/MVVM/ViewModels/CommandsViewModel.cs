using System.Windows.Input;

namespace MVVMDemo.MVVM.ViewModels
{
    public class CommandsViewModel
     {
          public ICommand ClickCommand { get; }
          public ICommand SearchCommand { get; }
          public string SearchTerm { get; set; }

          public CommandsViewModel()
          {
            ClickCommand = new Command(Alert);
            //SearchCommand = new Command((s) =>
            //   {
            //       object data = s;
            //   });
            SearchCommand = new Command( (s) => OnSearch(s));
          }

        private Action<object> OnSearch(object s)
        {
            object data = s;
            return null;
        }

        private void Alert()
          {
            App.Current.MainPage
                .DisplayAlert("Title", "message", "Ok");
          }       
     }
}
