using System;
using System.Text;

namespace Combinations
{
	public class Combinations
	{
		/* Each Char From the start of input to the End of string
		 * 		Choose the Char at Current Position
		 * 		Print Current Char
		 * 		if( Current Char is not the last char of Strin)
		 * 			Start Recursion to the next Char
		 * 		remove the last char
		 */ 
		private StringBuilder Strout = new StringBuilder();
		private String Strin;
		public Combinations (String str) 
		{ Strin = str;}

		public void combine() 
		{ 
			combine(0);
		}
		public void m_combine() 
		{ 
			m_combine(0);
		}
		private void combine(int Start)
		{
			for (int i = Start; i < Strin.Length; ++i) {
				Strout.Append (Strin [i]);
				Console.WriteLine (Strout.ToString());
				if (i < Strin.Length)
					combine (i + 1);
				Strout.Remove (Strout.Length-1, 1);
			}
		}
		private void m_combine(int Start)
		{
			for (int i = Start; i < Strin.Length; ++i) {
		
				Strout.Append (Strin [i]);
				Console.WriteLine (Strout.ToString());
				m_combine (i + 1);
				Strout.Remove (Strout.Length-1, 1);
			}
//			Strout.Append (Strin[Strin.Length - 1]);
//			Console.WriteLine (Strout.ToString());
//				Strout.Remove (Strout.Length - 1, 1);
		}
		public static void Main (string[] args)
		{
			Combinations combination = new Combinations ("wxyz");
			combination.m_combine ();
			Console.WriteLine ("Hello World!");
		}
	}
}
