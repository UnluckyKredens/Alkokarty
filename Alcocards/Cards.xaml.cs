using System.Diagnostics;

namespace Alcocards;

public partial class Cards : ContentPage
{
    int players;
    int card;
    string letter = "ABCDEFGHJKLMNOPQRSTUVWX";

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
        switch (card)
        {
            case 1:
                cardPick.Source = "ace.png";
                task.Text = "Wybierz osob� z kt�r� chcesz si� napi�";
                break;
            case 2:
                cardPick.Source = "two.png";
                task.Text = "wybierz osob� kt�ra ma si� napi�";
                break;
            case 3:
                cardPick.Source = "three.png";
                task.Text = "Pijesz ty";
                break;
            case 4:
                cardPick.Source = "four.png";
                task.Text = "Four Floor (kto ostatni da r�k� w d�)";
                break;
            case 5:
                cardPick.Source = "five.png";
                task.Text = "Five guys (Pij� ch�opaki)";
                break;
            case 6:
                cardPick.Source = "six.png";
                task.Text = "Six Chicks (Pij� dziewczyny)";
                break;
            case 7:
                cardPick.Source = "seven.png";
                task.Text = "Seven Heaven (kto ostatni da r�k� w g�re)";
                break;
            case 8:
                cardPick.Source = "eight.png";
                task.Text = "Wodospad (Pije ka�dy)";
                break;
            case 9:
                cardPick.Source = "nine.png";
                task.Text = "Rymy na litere: " + RandomLetter();
                break;
            case 10:
                cardPick.Source = "ten.png";
                task.Text = "Pa�stwo/Miasto na litere: " + RandomLetter();
                break;
            case 11:
                cardPick.Source = "jocker.png";
                task.Text = "Zadanie: \n";
                break;
            case 12:
                cardPick.Source = "queen.png";
                task.Text = "Nie wolno tej osobie odpowiedzie� na pytanie do nast�pnego wylosowania karty";// lista zada�
                break;
            case 13:
                cardPick.Source = "king.png";
                task.Text = "Nigdy przenigdy: \n"; // lista
                break;
        }
    }

    Char RandomLetter()
    {
        int index = rng.Next(1, letter.Length);
        return letter[index];
    }
}