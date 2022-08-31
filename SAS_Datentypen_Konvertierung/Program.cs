class Program
{
    public static void Main()
    {
        // Arbeitsauftrag 1 (selbstständige Internetrecherche notwendig):
        Aufgabe1();
        // Arbeitsauftrag 2 (effiziente Deklarierung):
        //Deklarieren und Initialisieren Sie folgende persönlichen Informationen auf eine ressourcen-schonende Weise.Geben Sie diese anschließend auf
        //eine optisch anschauliche Weise in der Konsole aus.
        Aufgabe2();
        Aufgabe3();
        Aufgabe4();
    }

    static void Aufgabe1()
    {
        Console.WriteLine("short = 16 Bitgröße | Wertebereich ist -2^(15) ... 2^(15) -1\nint = 32 Bitgröße | Wertebereich ist  -2^(31) ... 2^()31 -1\nlong = 64 Bitgröße | Wertebereich ist -2^(63) ... 2^(64) -1\nfloat = 32 Bitgröße | Wertebereich ist 1,4 x 10^(-45) bis 3,4 x 10^(38)\ndouble = 64 Bitgröße | Wertebereich ist 5,0 x 10^(-324) bis 1,7 x 10^(308)\ndecimal = 128 Bitgröße | Wertebereich ist ≈ +/-79E27 ohne Dezimalpunktangabe\n\n");
        

    }

    static void Aufgabe2()
    {
        string vorname = "Sean";
        byte alter = 16;
        bool antwort = true;
        Console.WriteLine("Ist C# die erste Programmiersprache,die Sie lernen?\n {0}", antwort);


    }

    static void Aufgabe3()
    {   
        
        int DollarZahl = 36;
        var newVariableDollarZahl = (char)DollarZahl;
        Console.WriteLine(newVariableDollarZahl);
            
    }
    
    static void Aufgabe4()
    {
        Console.WriteLine("Gebt eine Zahl im Wertebereich von short ein");
        short short_Number = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Geben sie auch noch eine Zahl im Wertebereich von double ein");
        double double_Number = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(short_Number);
        Console.WriteLine(double_Number);

    }
}
