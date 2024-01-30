using System.Reflection;

namespace MauiAssignement;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    async void OnImageButtonClicked(object sender, EventArgs e)
    {
        //Button btn = (Button)sender;
        ImageButton ImgBtn = (ImageButton)sender;
        string id = ImgBtn.StyleId;

        Assembly assembly = GetType().GetTypeInfo().Assembly;
        Type pageType = assembly.GetType("MauiAssignemnt." + id);
        Page page = (Page)Activator.CreateInstance(pageType);
        await Navigation.PushAsync(page);
    }
}