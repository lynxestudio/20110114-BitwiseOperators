using System;

namespace Samples.BitwiseCalc {
	public class BitwiseGUI {
		public static ushort Menu() {
			ushort option = 0;
			Console.WriteLine("\t\tOPERADORES BITWISE\n\n");
			Console.WriteLine("1. & AND");
			Console.WriteLine("2. | OR");
			Console.WriteLine("3. ^ Exclusive OR");
			Console.WriteLine("4. ~ NOT");
			Console.WriteLine("5. << Shift Left");
			Console.WriteLine("6. >> Shift right");
			Console.WriteLine();
			Console.WriteLine("0. Salir\n\n");
			Console.Write("Elija opción: ");
			try {
				option = Convert.ToUInt16(Console.ReadLine());
			}
			catch (FormatException) {
				Console.WriteLine("Opción no válida");
				option = 0;
			}
			return option;
		}

		public static void Pause() {
			Console.Write("\n\nPresiona cualquier tecla para continuar.");
			Console.Read();
		}

		public static void DisplayBinary(int i) {
			Console.WriteLine("{0} = {1}",i, Convert.ToString(i, 2).PadLeft(32,'0'));
		}

		public static int Prompt(string s) 	{
			int response = 0;
			Console.Write(s);
			string getResponse = Console.ReadLine ();
			if (!string.IsNullOrEmpty (getResponse))
				response = Convert.ToInt32 (getResponse);
			return response;
		}
	}
}