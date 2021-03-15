using System;

namespace FizzBuzz
{
	class Program
	{
		static void Main(string[] args)
		{
			foreach (var arg in args)
			{
				if (int.TryParse(arg, out int argInt))
				{
					Console.WriteLine(FizzBuzzProcessor.Calculate(argInt));
				}

			}
		}
	}
}
