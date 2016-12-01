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

			a = 55;
			b = 10;

			sum = a + b;

			//Writing in console

			Console.Write(a);
			Console.Write(" + ");
			Console.Write(b);
			Console.Write(" = ");
			Console.WriteLine(sum);

		}
	}
}
