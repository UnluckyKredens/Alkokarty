using Microsoft.Maui.Controls;
using System.ComponentModel;

namespace Alcocards;

public partial class PlayerNames : ContentPage
{
	int players_amount = MainPage.players;
    List<string> player_name = new List<string>();
    public PlayerNames()
	{
		InitializeComponent();
        for(int i = 0; i < players_amount; i++)
        {
            CreateEditor();
        }
    }

    void CreateEditor()
    {
        Entry editor = new Entry{Placeholder = "", HeightRequest = 35, WidthRequest = 350, BackgroundColor = Colors.White, HorizontalTextAlignment = TextAlignment.Center, MaxLength = 20, Keyboard = Keyboard.Plain };
        Layout.Add(editor);
        player_name.Add(editor.Text);
    }


}