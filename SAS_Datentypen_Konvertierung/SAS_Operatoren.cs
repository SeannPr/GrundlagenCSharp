using System;

class Program {
  public static void Main (string[] args) {
    //Aufgabe1();
    Aufgabe2();
  }

  static void Aufgabe1()
  {
    string a = "Hallo";
    string b = "H";
    b += "allo";

    Console.WriteLine(b); //Ausgabe: Hallo
    Console.WriteLine(b.Length); //Ausgabe: 5
    Console.WriteLine(a ==b); //Ausgabe: True
    Console.WriteLine((object)a == b); //Ausgabe: False
  }

  static void Aufgabe2()
  {
    
    double x = 2.0;
    double y = x * x + 1 + x / 4;
    Console.WriteLine(y);
    /*Erwartetes Ergebnis:
            1,75 
      Nach der Kompilierung:
            5.5 */
    double v = 2.0;
    double s = v * (v+1+v/4);
    Console.WriteLine(s);
    /*Erwartetes Ergebnis:
             2.5
      Nach der Kompilierung:
            7 */
    bool b = true && false || 5 > 6;
    Console.WriteLine(b);
    /*Erwartetes Ergebnis:
             false
      Nach der Kompilierung:
            False */
    int z = 50;
    bool numeric = z > 47 && z < 58;
    Console.WriteLine(numeric);
    /*Erwartetes Ergebnis:
             True / False
      Nach der Kompilierung:
            False True */
  }
}
