using System;
using System.Globalization;
using System.IO.Ports;
using System.Linq;

namespace NumberGuess
{
	class QuestionAsker
	{
		ButtonListener _listener = new ButtonListener(SerialPort.GetPortNames().First());
		public Boolean AskQuestion(String question)
		{
			
			Console.WriteLine(question);
			var cmd = _listener.ReadLine();
			return cmd.EndsWith("y\r",true,CultureInfo.CurrentCulture);
		}
	}
}