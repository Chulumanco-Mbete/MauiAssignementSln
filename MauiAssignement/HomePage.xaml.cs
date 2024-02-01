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
    private async void Ad_1_Button_Clicked(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://www.fxpro.com/");
    }
    private async void Video_1_Button_Clicked(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://youtu.be/Kt3EmcyS_N4");
    }
    private async void Video_12_Button_Clicked(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://youtu.be/UQ4VeJeDTH0");
    }
    private async void Video_13_Button_Clicked(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://youtu.be/ArhhQJpel-c");
    }
    private async void Ad_2_Button_Clicked(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://play.google.com/store/apps/details?id=com.king.candycrushsaga");
    }

    private async void Video_4_Button_Clicked(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://youtu.be/fFhH-pt9JW8");
    }
    private async void Video_17_Button_Clicked(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://youtu.be/sXOsmFED_9I");
    }
    private async void Video_14_Button_Clicked(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://youtu.be/MvPp-LF7Rlo");
    }

    private async void Ad_3_Button_Clicked(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://preply.com/");
    }

    private async void Video_15_Button_Clicked(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://youtu.be/EiUIMFFCVLs");
    }
    private async void Video_5_Button_Clicked(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://youtu.be/9ZQqq_mGYSM");
    }
    private async void Video_8_Button_Clicked(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://youtu.be/KMmKPfYhv20");
    }
    private async void Ad_4_Button_Clicked(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://www.booking.com/");
    }
}