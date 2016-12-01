using System;
using Gtk;

namespace Modul02
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Defining variables
			int a = 0, b = 0;
			int sum = 0;

			//Collection of numbers

			a = 10;
			b = 5;

			sum = a + b;

			//Writing in console

			Console.Write(a);
			Console.Write(" + ");
			Console.Write(b);
			Console.Write(" = ");
			Console.WriteLine(sum);

			//Extra operators

			Console.WriteLine("\nUsing +=");
			a += b;
			Console.Write(a);

			Console.WriteLine("\nUsing -=");
			a -= b;
			Console.Write(a);

			Console.WriteLine("\nUsing *=");
			a *= b;
			Console.Write(a);

			Console.WriteLine("\nUsing ++");
			a ++;
			Console.Write(a);

			Console.WriteLine("Standard divisione: " + ( 14/4 ).ToString()); 
			Console.WriteLine("Remainder of division: " + (14 % 4).ToString());

		}
	}
}
