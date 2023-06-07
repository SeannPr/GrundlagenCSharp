using System;

class Program 
{
public static void Main()
{
     int[] Numbers = {45, 10, 15, 4};
	 Numbers = Bubblesort(Numbers);
}
  public static int[] Bubblesort (int[] daten)
  {

   Console.WriteLine("Sorted Array:");
   for (int i = 0; i < daten.Length; i++)
   {
     Array.Sort(daten, i, daten.Length - i);
   }
   
	  foreach (int num in daten)
   {
     Console.WriteLine(num + " ");
     PrintBarLine(num);
   }
		

    
    return daten;
  }
 }
