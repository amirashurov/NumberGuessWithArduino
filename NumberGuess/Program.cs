using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuess
{
	class Program
	{
		static void Main(string[] args)
		{
			var numberGuess = new NumberGuess();
			numberGuess.Guess();
			Console.ReadKey();
		}
	}
}
