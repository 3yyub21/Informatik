//Methoden:

    string Nochmal;
    Console.WriteLine("Arbeiten mit Menthoden.");
    do
    {
        string Auswahl;
        Console.WriteLine("1:Quersumme Berechnung!");
        Console.WriteLine("2:Zeichen ersetzen!");
        Console.WriteLine("3: Vokale entfernen!");

    Console.Write("Auswahl:");
        Auswahl = Console.ReadLine();

        switch (Auswahl)
        {
            case "1":
                //Eingabe:
                int Zahl;
                Console.Write("Zahl eingeben: ");
                Zahl = Convert.ToInt32(Console.ReadLine());

                //Verarbeitung:
                int Ausgabe = 0;
                Ausgabe = Quersumme(Zahl);

                //Ausgabe:
                Console.WriteLine($"Die Quersumme von {Zahl} ist {Ausgabe}");
                break;
            case "2":
                //Eingabe:
                Console.WriteLine("Text eingeben:");
                string Text = Console.ReadLine();
                Console.Write("Welches Zeichen soll ersetzt werden?:");
                string zuErsetzen = Console.ReadLine();
                Console.WriteLine($"Wodurch soll{zuErsetzen} ersetzt werden?");
                string Ersatz = Console.ReadLine();

            //Verarbeitung:
            string neuertext = ZeichenErsetzen(Text,zuErsetzen,Ersatz);

             //Ausgabe:
             Console.WriteLine(neuertext);

                break;

            default:
                Console.WriteLine("ungültige Eingabe!");
                break;
        }

        Console.Write("Neue Auswahl?,(j/n)");
        Nochmal = Console.ReadLine();
    } while (Nochmal == "j" || Nochmal == "J");


    static int Quersumme(int Eingabezahl)
    {
        string Zahl = Eingabezahl.ToString();
        int Ausgabe = 0;

        for (int i = 0; i < Zahl.Length; i++)
        {
            Ausgabe += Convert.ToInt32(Zahl[i].ToString());
        }
        return Ausgabe;
    }

    static string ZeichenErsetzen(string text,string zuErsetzen,string Ersatz)
{
    string Ausgabe = "";
    for(int i = 0; i < text.Length; i++)
    {
        if (text[i].ToString() == zuErsetzen)
        {
            Ausgabe += Ersatz;
        }

        else
        {
            Ausgabe += text[i].ToString();

        }
    }
    return Ausgabe;
}

//Aufgabe 47:
//Strong Zahl!

Console.Write("Geben Sie ein Zahl ein: ");
int Zahl = Convert.ToInt32(Console.ReadLine());
int Summe = 0;

for(int i = Zahl; i != 0; i=i/10)
{
    int Produkt = 1;

    for (int j = 1; j <=i%10; j++)
    {
        Produkt = Produkt * j;
        
    }
    Summe = Summe + Produkt;
}

if (Summe == Zahl)
{
    Console.WriteLine("{0} ist Strong Zahl!",Zahl);
}

else
{
    Console.WriteLine("{0} ist nicht Strong Zahl!",Zahl);
}

//Aufgabe 48:
//Strong Number in range!

Console.Write("Geben Sie eine Anfangszahl ein: ");
int Anfangszahl = Convert.ToInt32(Console.ReadLine());
Console.Write("Geben Sie eine Endzahl ein: ");
int Endzahl = Convert.ToInt32(Console.ReadLine());
Console.Write("Alle Strong Zahlen Zwischen {0} und {1} sind : ",Anfangszahl,Endzahl);

for (int i=Anfangszahl; i <= Endzahl; i++)
{
    int Summe = 0;

    for (int j=i; j!=0; j=j/10)
    {
        int Factorial = 1;

        for(int k=1; k <= j%10; k++)
        {
            Factorial = Factorial * k;
        }

        Summe = Summe + Factorial;
    }
   
    if (Summe == i)
    {
        Console.Write("{0}" + " ", i);
    }
}
