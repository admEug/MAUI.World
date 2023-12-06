namespace DevsPark.Search
{
    public class OffersSearchHandler : SearchHandler
    {
        public OffersSearchHandler()
        {
            var service = Application.Current.MainPage
                .Handler
                .MauiContext
                .Services.GetService<OffersService>();

            ItemsSource = service.Offers;
        }
    }
}
