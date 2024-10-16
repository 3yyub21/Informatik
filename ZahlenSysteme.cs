Console.WriteLine("1:Decimalzahl zu Hexazahl");
Console.WriteLine("2:Decimalzahl zu Binärzahl");
Console.Write("Wählen Sie eine von Menü: ");
int Auswahl = int.Parse(Console.ReadLine());

switch (Auswahl)
{
    case 1:

        Console.Write("Geben Sie eine Decimalzahl ein: ");
        int Decimalzahl = int.Parse(Console.ReadLine());
        Console.WriteLine($"{Decimalzahl}_10 zu Hexazahl ist {DecimalZahlZuHexa(Decimalzahl)}_8");

        break;

        case 2:

        Console.Write("Geben Sie eine Demcimalzahl ein: ");
        Decimalzahl = int.Parse(Console.ReadLine());
        Console.WriteLine($"{Decimalzahl}_10 zu Binärzahl ist {DecimalZuBinär(Decimalzahl)}_2");

        break;
}
static int DecimalZahlZuHexa(int decimalzahl)
{
    int Hexazahl = 0;
    int j = 1;

    for (int i = decimalzahl; i > 0; i = i/8)
    {
        Hexazahl = Hexazahl + (decimalzahl % 8) * j;
        j = j * 10;
        decimalzahl = decimalzahl/ 8;
    }

    return Hexazahl;
}

static int DecimalZuBinär (int Decimalzahl)
{
    int Binärzahl = 0;
    int j = 1;

    for(int i = Decimalzahl; i > 0; i = i/2)
    {
        Binärzahl=Binärzahl+(Decimalzahl % 2) * j;
        j = j * 10;
        Decimalzahl = Decimalzahl / 2;
    }

    return Binärzahl;
}
