namespace ListExercises
{
using System;


class Program
	{
		static void Main()
		{
			var text = "pesho gosho i ivan";

			var count = new int[26];

			foreach (var symbol in text)
			{
				if (char.IsLetter(symbol))
				{
					count[symbol - 'a']++;
				}
			}

			for (int i = 0; i < count.Length; i++)
			{
				if (count[i]>0)
				{
					Console.WriteLine($"{(char)(i +'a')} - {count[i]}");
				}
			}
		}
	}
}
