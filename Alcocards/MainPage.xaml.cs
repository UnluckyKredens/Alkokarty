namespace Alcocards;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    async void NextPage(object sender, EventArgs args)
	{
            await Navigation.PushAsync(new Cards());
    }
}

