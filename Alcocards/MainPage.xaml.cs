namespace Alcocards;

public partial class MainPage : ContentPage
{
	public static int players = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    async void NextPage(object sender, EventArgs args)
	{
		if (player_ammount_field.Text == "0" || player_ammount_field.Text == null || player_ammount_field.Text == "")
		{
			await DisplayAlert("Uwaga!", "Proszę podać liczbę graczy!", "OK");
		} 
		else
		{
            players = int.Parse(player_ammount_field.Text);
            await Navigation.PushAsync(new PlayerNames());
        }
    }
}

