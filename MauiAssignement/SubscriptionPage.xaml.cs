namespace MauiAssignement;

public partial class SubscriptionPage : ContentPage
{
	public SubscriptionPage()
	{
		InitializeComponent();
        Routing.RegisterRoute("SearchPage", typeof(SearchPage));
    }
    private async void SearchButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("SearchPage");
    }

    private async void Ad_5_Button_Clicked(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://www.samsung.com/za/");
    }
    private async void Video_16_Button_Clicked(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://youtu.be/ElgoBqm7wFk");
    }
    private async void Video_6_Button_Clicked(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://youtu.be/veZOrXVHf7U");
    }
    private async void Video_9_Button_Clicked(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://youtu.be/GqulwE_yKww");
    }
    private async void Ad_6_Button_Clicked(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://za.shein.com/");
    }

    private async void Video_18_Button_Clicked(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://youtu.be/hH0mh0nrWO0");
    }
    private async void Video_2_Button_Clicked(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://youtu.be/UjmUhet1qW8");
    }
    private async void Video_3_Button_Clicked(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://youtu.be/NFh8ry3a9oY");
    }

    private async void Ad_7_Button_Clicked(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://www.betterhelp.com/");
    }

    private async void Video_11_Button_Clicked(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://youtu.be/DPjPcxp_dWs");
    }
    private async void Video_7_Button_Clicked(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://youtu.be/ErOzKJz6fo0");
    }
    private async void Video_10_Button_Clicked(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://youtu.be/4JdcO4UJkog");
    }
    private async void Ad_8_Button_Clicked(object sender, EventArgs e)
    {
        await Launcher.OpenAsync("https://www.onecart.co.za/");
    }
}