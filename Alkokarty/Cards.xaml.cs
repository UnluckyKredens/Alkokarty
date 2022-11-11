using System.Threading;
using System.Timers;
using Timer = System.Timers.Timer;

namespace Alcocards;

public partial class Cards : ContentPage
{
    readonly Random rng = new();
    Timer timer = new Timer();
    int card;
    readonly string letter = "ABCDEFGHJKLMNOPQRSTUWX";


    public Cards()
    {
        InitializeComponent();
        FindCard(null, null);
    }

    void FindCard(object sender, EventArgs e)
    { 
            card = rng.Next(1, 14);
            switch (card)
            {
                case 1:
                    cardPick.Source = "ace.png";
                    task.Text = "Wybierz osobê z któr¹ chcesz siê napiæ";
                    break;
                case 2:
                    cardPick.Source = "two.png";
                    task.Text = "wybierz osobê która ma siê napiæ";
                    break;
                case 3:
                    cardPick.Source = "three.png";
                    task.Text = "Pijesz ty";
                    break;
                case 4:
                    cardPick.Source = "four.png";
                    task.Text = "Four Floor (kto ostatni da rêkê w dó³)";
                    break;
                case 5:
                    cardPick.Source = "five.png";
                    task.Text = "Five guys (Pij¹ ch³opaki)";
                    break;
                case 6:
                    cardPick.Source = "six.png";
                    task.Text = "Six Chicks (Pij¹ dziewczyny)";
                    break;
                case 7:
                    cardPick.Source = "seven.png";
                    task.Text = "Seven Heaven (kto ostatni da rêkê w góre)";
                    break;
                case 8:
                    cardPick.Source = "eight.png";
                    task.Text = "Wodospad (Pije ka¿dy)";
                    break;
                case 9:
                    cardPick.Source = "nine.png";
                    task.Text = "Rymy na litere: \n" + RandomLetter();
                    break;
                case 10:
                    cardPick.Source = "ten.png";
                    task.Text = "Pañstwo/Miasto na litere: \n" + RandomLetter();

                    break;
                case 11:
                    cardPick.Source = "jocker.png";
                    task.Text = "Zadanie: \n" + GetTask(); // lista
                    break;
                case 12:
                    cardPick.Source = "queen.png";
                    task.Text = "Nie wolno tej osobie odpowiedzieæ na pytanie do nastêpnego wylosowania karty";
                    break;
                case 13:
                    cardPick.Source = "king.png";
                    task.Text = "Nigdy przenigdy: \n" + GetNeverEver(); // lista
                    break;
            }
    }

    Char RandomLetter()
    {
        int index = rng.Next(1, letter.Length);
        return letter[index];
    }

    public string GetTask()
    {
        int num = rng.Next(0, 50);
        return num switch
        {
            0 => "Udawaj chlopaka / dziewczyne osoby obok",
            1 => "Wypij drinka zrobionego przez innych graczy",
            2 => "Uszereguj graczy od najmniej atrakcyjnych",
            3 => "Poka¿ najbardziej ¿enuj¹ce zdjêcie w telefonie",
            4 => "Wykrzycz pierwsze s³owo, które przyjdzie ci do g³owy",
            5 => "Opró¿nij kieszenie i poka¿ wszystkim, co jest w œrodku",
            6 => "Usuñ dwie czêœci garderoby",
            7 => "Spróbuj polizaæ ³okieæ",
            8 => "Niech ktoœ ogoli czêœæ twojego cia³a",
            9 => "Zatañcz na wybranej przez grupe osobie",
            10 => "Opowiedz wszystkim wstydliw¹ historiê o sobie",
            11 => "Dla faceta na³ó¿ makija¿. Dla dziewczyny zmyj makija¿",
            12 => "Wyj jak wilk",
            13 => "Daj siê po³askotaæ komuœ innemu i postaraj siê nie œmiaæ",
            14 => "Poca³uj osobê po lewej",
            15 => "Daj siê spoliczkowaæ przez wybran¹ przez siebie osobê",
            16 => "UwiedŸ w grupie cz³onka tej samej p³ci",
            17 => "Grupa wybiera kto ma daæ ci klapsa",
            18 => "Otwórz paczkê przek¹sek lub cukierków u¿ywaj¹c tylko ust",
            19 => "Grupa wybiera kto siada ci na twarzy",
            20 => "B³agaj i b³agaj osobê po swojej prawej stronie, aby nie zostawia³a ciê dla innego",
            21 => "Poca³uj kogoœ",
            22 => "Zdejmij skarpetki",
            23 => "Pozwól innym graczom przejœæ przez Twój telefon przez minutê",
            24 => "Wykonaj 20 przysiadów",
            25 => "Wykonaj 20 pompek",
            26 => "Œmieszny telefon do kogoœ",
            27 => "Rób deskê (plank) przez pe³n¹ minutê",
            28 => "Podrzuæ kogoœ do góry",
            29 => "Przeczytaj na g³os piêæ ostatnich wyszukiwañ w telefonie",
            30 => "Opisz najbardziej atrakcyjn¹ czêœæ ka¿dej osoby w pokoju",
            31 => "Wyœlij sms-a do kogoœ z wyznaniem mi³osnym",
            32 => "Zrób komuœ malinkê na ramieniu",
            33 => "Zamieñ siê ubraniami z osob¹ siedz¹c¹ obok",
            34 => "Przytul osobe ko³o siebie",
            35 => "Dirty Dancing",
            36 => "Spróbuj zagwizdaæ na palcach",
            37 => "Zapytaj losowego przechodnia o zdjêcie, jak sie zgodzi pokaz je grupie",
            38 => "Zrób szpagat",
            39 => "Czy mia³eœ mokre sny z ktor¹s/ktorymœ z graczy?",
            40 => "Opowiedz historie ktora wywoluje u ciebie cringe",
            41 => "Zaprezentuj pozycje na pieska",
            42 => "Drink piwo/wódka",
            43 => "Za³ó¿ szpilki i przejdŸ siê jak modelka po wybiegu",
            44 => "Przebiegnij dwa kó³ka wokó³ domu",
            45 => "Zdejmij jak¹œ czêœæ garderoby i kontynuuj grê bez niej",
            46 => "Zdejmij jak¹œ czêœæ garderoby i kontynuuj grê bez niej",
            47 => "Zdejmij jak¹œ czêœæ garderoby i kontynuuj grê bez niej",
            48 => "Z iloma partnerami/partnerkami spa³aœ",
            49 => "Czy kiedykolwiek zdradzi³aœ swojego partnera",
            50 => "Powiedzieæ ca³y alfabet od ty³u i we wskazanym limicie czasu",
            _ => "coœ posz³o nie tak",
        };
    }

    public string GetNeverEver()
    {
        int num = rng.Next(0, 40);
        return num switch
        {
            0 => "Nie mia³em/am FWB",
            1 => "Nie wys³a³em/am softa/nudesa",
            2 => "Nie mia³em/am One Night Stand",
            3 => "Nie pi³em/am sam",
            4 => "Nie spa³em/am pijany na dworze",
            5 => "Nie próbowa³em/am narkotyków",
            6 => "Nie oszuka³em/am policji",
            7 => "Nie uderzy³em/am p³ci przeciwnej",
            8 => "Nie obudzi³em/am siê obok nieznajomego",
            9 => "Nie k³ama³em/am o seksie",
            10 => "Nie krêci³em/am z zajêt¹ osob¹",
            11 => "Nie pi³em/am w szkole",
            12 => "Nie pi³em/am aby zyskaæ pewnoœæ siebie",
            13 => "Nie pali³em/am zio³a",
            14 => "Nie by³em/am w zwi¹zku",
            15 => "Nie by³em/am bliski œmierci",
            16 => "Nie lata³em/am samolotem",
            17 => "Nie mia³em/am operacji",
            18 => "Nie pisa³em/am do kogoœ po alkoholu",
            19 => "Nie udawa³em/am choroby",
            20 => "Nie zwymiotowa³em/am gdzieœ indziej ni¿ toaleta",
            21 => "Nie podoba³ mi siê nauczyciel",
            22 => "Nie æwiczy³em/am ca³owania za pomoc¹ poduszki",
            23 => "Nie gra³em/am w pokera",
            24 => "Nie spóŸni³em/am siê",
            25 => "Nie po³ama³em/am koœci",
            26 => "Nie by³em/am szyty",
            27 => "Nie pi³em/am alkoholu",
            28 => "Nie uprawia³em/am sportu po alkoholu",
            29 => "Nie zemdla³em/am przez alkohol",
            30 => "Nie prowadzi³em/am samochodu po alkoholu",
            31 => "Nie mia³em/am ataku paniki",
            32 => "Nie tañczy³em/am w barze",
            33 => "Nie zosta³em/am wyrzucony z baru/klubu",
            34 => "Nie by³em/am skuty kajdankami",
            35 => "Nie wychodzi³em/am przez okno",
            36 => "Nie mia³em/am tatua¿u",
            37 => "Nie imprezowa³em/am wiêcej ni¿ 24H",
            38 => "Nie dosta³em/am darmowego drinka",
            39 => "Nie bylem/am w klubie ze striptizem",
            40 => "Nie kupowa³em/am alkoholu niepe³noletni/a",
            _ => "coœ posz³o nie tak",
        };
    }
}