using System;

class Program
{
	static void Main()
	{
		int n = 10; // Change this value to compute up to the nth Fibonacci number
		for (int i = 0; i < n; i++)
		{
			Console.WriteLine("Fibonacci(" + i + ") = " + Fibonacci(i));
		}
	}

	static int Fibonacci(int n)
	{
		if (n <= 1)
			return n;

		int a = 0;
		int b = 1;
		int c;

		for (int i = 2; i <= n; i++)
		{
			c = a + b;
			a = b;
			b = c;
		}

		return b;
	}
}