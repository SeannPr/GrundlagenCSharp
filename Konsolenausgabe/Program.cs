class Program
{
    public static void Main()
    {
        Aufgabe1();
        Aufgabe2();
        Aufgabe3();
    }


    static void Aufgabe1()
    {

        Console.WriteLine(" .-.");
        Console.WriteLine("(O O)");
        Console.WriteLine("| 0 |");
        Console.WriteLine("|   |");
        Console.WriteLine("´~~~´");

    }

    static void Aufgabe2()
    {

        string Vorname = "Sean";
        string Nachname = "Prior";
        string Alter = "16";


        Console.WriteLine(Vorname);
        Console.WriteLine(Nachname);
        Console.WriteLine(Alter);


    }

    static void Aufgabe3()
    {
        Console.WriteLine("Nennen sie mir bitte ihren namen.");
        string Vorname = Console.ReadLine();
        Console.WriteLine("Wie lautet ihr alter?");
        string Alter = Console.ReadLine();
        Console.WriteLine("Welche Klasse besuchen sie auf der Gso?");
        string klasse = Console.ReadLine();
        Console.WriteLine($"{Vorname} ist {Alter} Jahre alt und besucht die {klasse} des Georg-Simon-Ohm Berufskollegs.");
       

    }

}
