namespace Alcocards;

public partial class PlayerNames : ContentPage
{
	int players_amount = MainPage.players;

	public PlayerNames()
	{
		InitializeComponent();
		// Dodaje do contentu nowy scrollview
		Content = new ScrollView
		{
			BackgroundColor = Color.FromArgb("111111"),
            // Dodaje do contentu nowy StackLayout
            Content = new StackLayout
			{
				Padding = 20,
				Spacing = 30,

				Children =
				{
					// TODO: tworzenie edytorów, dla danej liczby graczy - for
					new Editor
					{
						BackgroundColor = Color.FromArgb("FFFFFF"),
						Text = "text",
						TextColor = Color.FromArgb("111111")
					}
                }
			}
		};
		
    }
}