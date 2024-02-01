using System.Reflection;

namespace MauiAssignement;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
        Routing.RegisterRoute("SearchPage", typeof(SearchPage));
	}

    private async void SearchButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("SearchPage");
    }

    private void Ad_1_Button_Clicked(object sender, EventArgs e)
    {
        WebView webvView = new WebView
        {
            Source = "https://www.fxpro.com/"
        };
    }

}