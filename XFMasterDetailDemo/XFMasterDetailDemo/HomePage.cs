using Xamarin.Forms;

namespace XFMasterDetailDemo
{
    internal class HomePage : ContentPage
    {
        public HomePage()
        {
            var button = new Button
            {
                Text = "navigate to inner page"
            };

            button.Clicked += (sender, args) =>
            {
                Navigation.PushAsync(new InnerDetailPage());
            };

            Content = button;

            Title = "Home";
        }
    }
}