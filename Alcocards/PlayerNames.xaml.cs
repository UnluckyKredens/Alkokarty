using Microsoft.Maui.Controls;
using System.ComponentModel;

namespace Alcocards;

public partial class PlayerNames : ContentPage
{
    int players_amount = MainPage.players;
    public List<string> player_names_list = new List<string>();
    public PlayerNames()
	{
		InitializeComponent();
        
        for (int i = 0; i < players_amount; i++)
        {
            
            CreateEditor();
        }
        
    }

    void CreateEditor()
    {

        Entry editor = new Entry
        {
            Placeholder = "Nazwa gracza",
            PlaceholderColor = Color.FromArgb("#5a5a5a"),
            FontFamily = "Jetbrains",
            FontSize = 18,
            HeightRequest = 45,
            WidthRequest = 350,
            BackgroundColor = Colors.White,
            HorizontalTextAlignment = TextAlignment.Center,
            MaxLength = 20,
            Keyboard = Keyboard.Plain,       
    };
        Layout.Add(editor);
        editor.Completed += OnEditorCompleted;
        
    }

    void OnEditorCompleted(object sender, EventArgs e)
    {
        player_names_list.Add(((Entry)sender).Text);
    }

     void NextPage(object sender, EventArgs e)
    {
        Cards.players = player_names_list;
         Navigation.PushAsync(new Cards());
    }
}