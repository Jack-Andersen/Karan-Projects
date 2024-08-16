using System;

class Program
{
	static void Main()
	{
		int number = 14; // Change this value to find the next prime after this number
		int nextPrime = FindNextPrime(number);
		Console.WriteLine("The next prime number after " + number + " is: " + nextPrime);
	}

	static int FindNextPrime(int number)
	{
		int nextNumber = number + 1;

		while (!IsPrime(nextNumber))
		{
			nextNumber++;
		}

		return nextNumber;
	}

	static bool IsPrime(int number)
	{
		if (number <= 1)
			return false;
		if (number == 2 || number == 3)
			return true;
		if (number % 2 == 0 || number % 3 == 0)
			return false;

		for (int i = 5; i * i <= number; i += 6)
		{
			if (number % i == 0 || number % (i + 2) == 0)
				return false;
		}

		return true;
	}
}