string Wiederholung;
do
{
    Random rnd = new Random();
    int zufallszahl = rnd.Next(1, 7);
    string Auswahl;

    Console.WriteLine("Auswhlmenü:");
    Console.WriteLine("1: Summme der Brüche 1/a bis 1/b");
    Console.WriteLine("2: Verflixte 4 ");
    Console.WriteLine("3: Palindrom");
    Console.Write("Auswahl=");
    Auswahl = Console.ReadLine();

    switch (Auswahl)
    {
        case "1":

            int a, b;
            double summe = 0;
            Console.Write("a=  (a!=0):");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                int c = a;
                a = b;
                b = c;
            }

            for (int i = a; i <= b; i++)
            {
                summe = summe + 1.0 / i; //summme += 1/i;

            }
            Console.WriteLine("Die Summe der Brüche von 1/{0} + 1/{1} ergibt = {2}", a, b, Math.Round(summe));

            break;


        case "2":
            int m;
            Console.Write("m =");
            m = Convert.ToInt32(Console.ReadLine());

            for (int j = 1; j <= m; j++)
            {

                if (j % 4 == 0 || j.ToString().Contains('4'))
                {
                    Console.WriteLine("---4---");
                }
                else
                {
                    Console.WriteLine(j);
                }
            }

            break;

        case "3":
            Console.WriteLine("Geben Sie ein Wort ein : ");
            string Wort = Console.ReadLine();


            break;

        default:

            Console.WriteLine("Ungültige eingabe!");

            break;
    }
    Console.WriteLine("Weitere Berechnungen ?,(j/n)");
    Wiederholung = Console.ReadLine();
} while (Wiederholung == "j");
