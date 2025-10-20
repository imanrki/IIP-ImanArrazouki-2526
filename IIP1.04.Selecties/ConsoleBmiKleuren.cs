using System;

class Program
{
   static void Main(string[] args)
   {
       Console.WriteLine("BMI CALCULATOR");
	 Console.WriteLine("==============");
     Console.Write("Geef je lengte in cm: ");
	 int lengteCm = Convert.ToInt32(Console.ReadLine());
	 // lengte omzetten van cm naar meter
	 double lengteM = (double)lengteCm / 100.00;
	 Console.Write("Geef je gewicht in kg: ");
	 double gewichtKg = Convert.ToInt32(Console.ReadLine());
	 double bmi = gewichtKg / (lengteM * lengteM);
	 double bmiAfgerond = Math.Round(bmi, 1);
	 Console.WriteLine($"Je Bmi is {bmiAfgerond}");
	 if (bmiAfgerond <= 18.5)
	 {
		 Console.ForegroundColor = ConsoleColor.Red;
		 Console.WriteLine("Je hebt ondergewicht");		
		 Console.ResetColor();
	 }
	 else if(bmiAfgerond >= 18.5 && bmiAfgerond <= 25)
	{
		Console.ForegroundColor = ConsoleColor.Blue;
		Console.WriteLine ("Je gewicht is normaal");
		Console.ResetColor();
	}
	else
	{
		Console.ForegroundColor= ConsoleColor.White;
		Console.WriteLine("Je hebt overgewicht");
		Console.ResetColor();
	}
   }
  }
