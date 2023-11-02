namespace Maui.Hello._7
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContentPageDemo());
            //Navigation.PopAsync();
        }
    }
}