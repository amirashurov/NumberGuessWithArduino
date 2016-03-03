using System;

namespace NumberGuess
{
	class NumberGuess
	{
		readonly QuestionAsker _asker = new QuestionAsker();

		public void Guess(Int32 max = 100000)
		{
			Int32 secret = 0;
			Int32 answer = 0;
			
			Console.WriteLine("Загадайте число от 0 до {0}", max);
			while (true)
			{
				answer = (secret + max) / 2;
				if (max - secret >= 2)
				{
					if (_asker.AskQuestion(string.Format("Ваше число >= {0} ?", answer))) secret = answer;
					else max = answer;
					
				}
				else
				{
					Console.WriteLine("Ваше число = {0}", secret);
					break;
				}
			}
		}
	}
}