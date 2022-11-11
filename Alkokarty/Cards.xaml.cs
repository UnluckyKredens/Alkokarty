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
                    task.Text = "Rymy na litere: \n" + RandomLetter();
                    break;
                case 10:
                    cardPick.Source = "ten.png";
                    task.Text = "Pa�stwo/Miasto na litere: \n" + RandomLetter();

                    break;
                case 11:
                    cardPick.Source = "jocker.png";
                    task.Text = "Zadanie: \n" + GetTask(); // lista
                    break;
                case 12:
                    cardPick.Source = "queen.png";
                    task.Text = "Nie wolno tej osobie odpowiedzie� na pytanie do nast�pnego wylosowania karty";
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
            3 => "Poka� najbardziej �enuj�ce zdj�cie w telefonie",
            4 => "Wykrzycz pierwsze s�owo, kt�re przyjdzie ci do g�owy",
            5 => "Opr�nij kieszenie i poka� wszystkim, co jest w �rodku",
            6 => "Usu� dwie cz�ci garderoby",
            7 => "Spr�buj poliza� �okie�",
            8 => "Niech kto� ogoli cz�� twojego cia�a",
            9 => "Zata�cz na wybranej przez grupe osobie",
            10 => "Opowiedz wszystkim wstydliw� histori� o sobie",
            11 => "Dla faceta na�� makija�. Dla dziewczyny zmyj makija�",
            12 => "Wyj jak wilk",
            13 => "Daj si� po�askota� komu� innemu i postaraj si� nie �mia�",
            14 => "Poca�uj osob� po lewej",
            15 => "Daj si� spoliczkowa� przez wybran� przez siebie osob�",
            16 => "Uwied� w grupie cz�onka tej samej p�ci",
            17 => "Grupa wybiera kto ma da� ci klapsa",
            18 => "Otw�rz paczk� przek�sek lub cukierk�w u�ywaj�c tylko ust",
            19 => "Grupa wybiera kto siada ci na twarzy",
            20 => "B�agaj i b�agaj osob� po swojej prawej stronie, aby nie zostawia�a ci� dla innego",
            21 => "Poca�uj kogo�",
            22 => "Zdejmij skarpetki",
            23 => "Pozw�l innym graczom przej�� przez Tw�j telefon przez minut�",
            24 => "Wykonaj 20 przysiad�w",
            25 => "Wykonaj 20 pompek",
            26 => "�mieszny telefon do kogo�",
            27 => "R�b desk� (plank) przez pe�n� minut�",
            28 => "Podrzu� kogo� do g�ry",
            29 => "Przeczytaj na g�os pi�� ostatnich wyszukiwa� w telefonie",
            30 => "Opisz najbardziej atrakcyjn� cz�� ka�dej osoby w pokoju",
            31 => "Wy�lij sms-a do kogo� z wyznaniem mi�osnym",
            32 => "Zr�b komu� malink� na ramieniu",
            33 => "Zamie� si� ubraniami z osob� siedz�c� obok",
            34 => "Przytul osobe ko�o siebie",
            35 => "Dirty Dancing",
            36 => "Spr�buj zagwizda� na palcach",
            37 => "Zapytaj losowego przechodnia o zdj�cie, jak sie zgodzi pokaz je grupie",
            38 => "Zr�b szpagat",
            39 => "Czy mia�e� mokre sny z ktor�s/ktorym� z graczy?",
            40 => "Opowiedz historie ktora wywoluje u ciebie cringe",
            41 => "Zaprezentuj pozycje na pieska",
            42 => "Drink piwo/w�dka",
            43 => "Za�� szpilki i przejd� si� jak modelka po wybiegu",
            44 => "Przebiegnij dwa k�ka wok� domu",
            45 => "Zdejmij jak�� cz�� garderoby i kontynuuj gr� bez niej",
            46 => "Zdejmij jak�� cz�� garderoby i kontynuuj gr� bez niej",
            47 => "Zdejmij jak�� cz�� garderoby i kontynuuj gr� bez niej",
            48 => "Z iloma partnerami/partnerkami spa�a�",
            49 => "Czy kiedykolwiek zdradzi�a� swojego partnera",
            50 => "Powiedzie� ca�y alfabet od ty�u i we wskazanym limicie czasu",
            _ => "co� posz�o nie tak",
        };
    }

    public string GetNeverEver()
    {
        int num = rng.Next(0, 40);
        return num switch
        {
            0 => "Nie mia�em/am FWB",
            1 => "Nie wys�a�em/am softa/nudesa",
            2 => "Nie mia�em/am One Night Stand",
            3 => "Nie pi�em/am sam",
            4 => "Nie spa�em/am pijany na dworze",
            5 => "Nie pr�bowa�em/am narkotyk�w",
            6 => "Nie oszuka�em/am policji",
            7 => "Nie uderzy�em/am p�ci przeciwnej",
            8 => "Nie obudzi�em/am si� obok nieznajomego",
            9 => "Nie k�ama�em/am o seksie",
            10 => "Nie kr�ci�em/am z zaj�t� osob�",
            11 => "Nie pi�em/am w szkole",
            12 => "Nie pi�em/am aby zyska� pewno�� siebie",
            13 => "Nie pali�em/am zio�a",
            14 => "Nie by�em/am w zwi�zku",
            15 => "Nie by�em/am bliski �mierci",
            16 => "Nie lata�em/am samolotem",
            17 => "Nie mia�em/am operacji",
            18 => "Nie pisa�em/am do kogo� po alkoholu",
            19 => "Nie udawa�em/am choroby",
            20 => "Nie zwymiotowa�em/am gdzie� indziej ni� toaleta",
            21 => "Nie podoba� mi si� nauczyciel",
            22 => "Nie �wiczy�em/am ca�owania za pomoc� poduszki",
            23 => "Nie gra�em/am w pokera",
            24 => "Nie sp�ni�em/am si�",
            25 => "Nie po�ama�em/am ko�ci",
            26 => "Nie by�em/am szyty",
            27 => "Nie pi�em/am alkoholu",
            28 => "Nie uprawia�em/am sportu po alkoholu",
            29 => "Nie zemdla�em/am przez alkohol",
            30 => "Nie prowadzi�em/am samochodu po alkoholu",
            31 => "Nie mia�em/am ataku paniki",
            32 => "Nie ta�czy�em/am w barze",
            33 => "Nie zosta�em/am wyrzucony z baru/klubu",
            34 => "Nie by�em/am skuty kajdankami",
            35 => "Nie wychodzi�em/am przez okno",
            36 => "Nie mia�em/am tatua�u",
            37 => "Nie imprezowa�em/am wi�cej ni� 24H",
            38 => "Nie dosta�em/am darmowego drinka",
            39 => "Nie bylem/am w klubie ze striptizem",
            40 => "Nie kupowa�em/am alkoholu niepe�noletni/a",
            _ => "co� posz�o nie tak",
        };
    }
}