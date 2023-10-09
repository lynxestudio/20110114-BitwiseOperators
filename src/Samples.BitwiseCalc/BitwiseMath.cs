using System;

namespace Samples.BitwiseCalc {
	public class BitwiseMath {
		public delegate int DelBinOp(int a,int b);
		public delegate int DelUriOp(int a);

		public static void BinaryOp(DelBinOp del) {
			int op1 = BitwiseGUI.Prompt ("Teclee el primer operador: ");
			int op2 = BitwiseGUI.Prompt ("Teclee el segundo operador: ");
			int resp = del(op1,op2);
			Console.WriteLine();
			BitwiseGUI.DisplayBinary(op1);
			BitwiseGUI.DisplayBinary(op2);
			Console.WriteLine("----------------------------");
			BitwiseGUI.DisplayBinary(resp);
			BitwiseGUI.Pause();
		}

		public static void ShiftOp(DelBinOp del){
			int op1 = BitwiseGUI.Prompt ("Teclee el primer operador: ");
			int op2 = BitwiseGUI.Prompt ("Teclee las posiciones: ");
			int resp = del(op1, op2);
			Console.WriteLine();
			BitwiseGUI.DisplayBinary(op1);
			Console.WriteLine("-----------------------");
			BitwiseGUI.DisplayBinary(resp);
			BitwiseGUI.Pause();
		}

		public static void UnaryOp(DelUriOp del) {
			int op1 = BitwiseGUI.Prompt ("Teclee el primer operador: ");
			int resp = del(op1);
			BitwiseGUI.DisplayBinary(op1);
			Console.WriteLine("-----------------------");
			BitwiseGUI.DisplayBinary(resp);
			BitwiseGUI.Pause();
		}

	}
}