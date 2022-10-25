namespace Alcocards;

public partial class Cards : ContentPage
{
	int players;
	int card;
	Random rng = new Random();
	public Cards()
	{
		InitializeComponent();
		FindCard(null, null);


    }

	void FindPlayer()
	{

	}

	void FindCard(object sender, EventArgs e)
	{
		card = rng.Next(1, 14);	
		switch(card)
		{
			case 1:
				cardPick.Source = "ace.png";

                break;
            case 2:
                cardPick.Source = "two.png";

                break;
            case 3:
                cardPick.Source = "three.png";

                break;
            case 4:
                cardPick.Source = "four.png";

                break;
            case 5:
                cardPick.Source = "five.png";

                break;
            case 6:
                cardPick.Source = "six.png";

                break;
            case 7:
                cardPick.Source = "seven.png";

                break;
            case 8:
                cardPick.Source = "eight.png";

                break;
            case 9:
                cardPick.Source = "nine.png";

                break;
            case 10:
                cardPick.Source = "ten.png";

                break;
            case 11:
                cardPick.Source = "jocker.png";

                break;
            case 12:
                cardPick.Source = "queen.png";

                break;
            case 13:
                cardPick.Source = "king.png";

                break;

        }
	}
}