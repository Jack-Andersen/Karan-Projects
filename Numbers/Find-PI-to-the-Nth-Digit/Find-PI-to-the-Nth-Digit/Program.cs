using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("Enter the number of decimal places for PI: ");
		int n = int.Parse(Console.ReadLine());

		if (n < 0 || n > 15)
		{
			Console.WriteLine("Please enter a number between 0 and 15.");
		}
		else
		{
			// Use the Math.PI constant and format it to N decimal places
			string piToNthDigit = Math.PI.ToString("F" + n);
			Console.WriteLine($"PI to {n} decimal places: {piToNthDigit}");
		}
	}
}