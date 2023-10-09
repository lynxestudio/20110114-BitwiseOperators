using System;

namespace Samples.BitwiseCalc {
	class MainClass {
		public static void Main (string[] args) {
			ushort option = 0;
			do {
				option = BitwiseGUI.Menu();
				switch(option){
				case 1:
					Console.WriteLine("\t\t[ & AND ]\n\n");
					BitwiseMath.BinaryOp((a, b) =>a & b);
					break;
				case 2:
					Console.WriteLine("\t\t[ | OR ]\n\n");
					BitwiseMath.BinaryOp((a,b) => a | b);
					break;
				case 3:
					Console.WriteLine("\t\t[ ^ Exclusive OR ]\n\n");
					BitwiseMath.BinaryOp((a,b) => a ^ b);
					break;
				case 4:
					Console.WriteLine("\t\t[ ~ NOT ]\n\n");
					BitwiseMath.UnaryOp(a => ~a);
					break;
				case 5:
					Console.WriteLine("\t\t[ << Shift Left ]\n\n");
					BitwiseMath.ShiftOp((a,b) => a << b);
					break;
				case 6:
					Console.WriteLine("\t\t[ >> Shift right ]\n\n");
					BitwiseMath.ShiftOp((a,b) => a >> b);
					break;

				}
			} while (option > 0);
		}
	}
}