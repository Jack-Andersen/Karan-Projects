using System;
using System.Numerics;

class Program
{
	static void Main()
	{
		int digits = 50; // Change this to the number of digits you want
		int maxIterations = 10000; // Increase for more accuracy if needed

		string e = CalculateE(digits, maxIterations);
		Console.WriteLine("e to " + digits + " digits:");
		Console.WriteLine(e);
	}

	static string CalculateE(int digits, int maxIterations)
	{
		BigInteger factorial = 1;
		BigDecimal e = new BigDecimal(2, digits);
		BigDecimal term;
		int scale = digits + 10;

		for (int i = 2; i < maxIterations; i++)
		{
			factorial *= i;
			term = new BigDecimal(1, scale) / new BigDecimal(factorial, scale);
			e += term;

			if (term.IsZero())
				break;
		}

		return e.ToString().Substring(0, digits + 2); // "+2" includes "2." in "2.71828..."
	}
}

public struct BigDecimal
{
	private BigInteger integer;
	private int scale;

	public BigDecimal(BigInteger integer, int scale)
	{
		this.integer = integer;
		this.scale = scale;
	}

	public static BigDecimal operator +(BigDecimal left, BigDecimal right)
	{
		return new BigDecimal(left.integer + right.integer, left.scale);
	}

	public static BigDecimal operator /(BigDecimal left, BigDecimal right)
	{
		BigInteger numerator = left.integer * BigInteger.Pow(10, right.scale);
		BigInteger denominator = right.integer;
		return new BigDecimal(numerator / denominator, left.scale);
	}

	public bool IsZero()
	{
		return integer == 0;
	}

	public override string ToString()
	{
		string integerStr = integer.ToString();
		if (scale > 0)
		{
			if (integerStr.Length <= scale)
			{
				integerStr = integerStr.PadLeft(scale + 1, '0');
			}

			integerStr = integerStr.Insert(integerStr.Length - scale, ".");
		}
		return integerStr;
	}
}