using System;

class Program
{
   static void Main(string[] args)
   {
	 Console.WriteLine("BMI CALCULATOR");
	 Console.WriteLine("==============");
     Console.Write("Geef je lengte in cm: ");
	 double lengteCm = Convert.ToInt32(Console.ReadLine());
	 // lengte omzetten van cm naar meter
	 double lengteM = lengteCm / 100.00;
	 Console.Write("Geef je gewicht in kg: ");
	 double gewichtKg = Convert.ToInt32(Console.ReadLine());
	 double bmi = gewichtKg / lengteM;
	 double bmiAfgerond = Math.Round(bmi, 1);
	 Console.WriteLine($"Je Bmi is {bmiAfgerond}");
	 
   }
}