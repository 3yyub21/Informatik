string Wiederhlung;
do
{
    Console.WriteLine("Menü");
    Console.WriteLine("1:Addition");
    Console.WriteLine("2:Subtraktion");
    Console.WriteLine("3:Multiplikation");
    Console.WriteLine("4:Quotient");
    Console.Write("Auswahl:");
    int Auswahl;
    Auswahl = Convert.ToInt32(Console.ReadLine());

    if (Auswahl == 1)
    {
        Console.WriteLine("Geben Sie die Summanden ein:");
        double a, b;
        Console.Write("a =");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b =");
        b = Convert.ToDouble(Console.ReadLine());

        double summe = a + b;
        Console.WriteLine("Ergebnis lautet :" + summe);
    }
    else if (Auswahl == 2)
    {
        Console.WriteLine("Geben Sie die Minuend und die Subtrahend ein :");
        double a, b;
        Console.Write("a =");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b =");
        b = Convert.ToDouble(Console.ReadLine());

        double Differenz = a - b;
        Console.WriteLine("Ergebnis lautet: {0}", Differenz);
    }
    else if (Auswahl == 3)
    {
        Console.WriteLine("Geben Sie die Faktoren ein:");
        double a, b;
        Console.Write("a =");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b =");
        b = Convert.ToDouble(Console.ReadLine());

        double Produkt = a * b;
        Console.WriteLine("Ergebnis lautet :{0}", Produkt);
    }
    else if (Auswahl == 4)
    {
        Console.WriteLine("Geben Sie die Dividend und die Divisor ein:");
        double a, b;
        Console.Write("a =");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b =");
        b = Convert.ToDouble(Console.ReadLine());

        double Quotient = a / b;
        Console.WriteLine("Ergebnis lautet : {0}", Quotient);
    }
    else
    {
        Environment.Exit(0);
    }
    Console.WriteLine("Weitere Berechnungen?,(j/n)");
    Wiederhlung = Console.ReadLine();
} while (Wiederhlung == "j");
