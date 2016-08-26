using System;
using Xamarin.Forms;

namespace XFMasterDetailDemo
{
    internal class SliderView : ContentPage
    {
        public SliderView()
        {
            var button1 = new Button
            {
                Text = "Page1",
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            var button2 = new Button
            {
                Text = "Page2",
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            button2.Clicked += (sender, args) =>
            {
                var masterDetailPage = Application.Current.MainPage as MasterDetailPage;
                if (masterDetailPage != null)
                {
                    masterDetailPage.Detail = new NavigationPage(new ListViewWithGrid());
                }
            };

            button1.Clicked += (sender, args) =>
            {
                var masterDetailPage = Application.Current.MainPage as MasterDetailPage;
                if (masterDetailPage != null)
                {
                    masterDetailPage.Detail = new NavigationPage(new HomePage());
                }
            };

            Content = new StackLayout
            {
                Children =
                {
                    button1,
                    button2
                },
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Spacing = 10,
                Padding = 10,
            };

            Title = "Master";
            Icon = "hamburger.png";
        }
    }
}