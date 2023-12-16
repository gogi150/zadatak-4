using System;
					
public class Program
{
	public static void Main()
	{
       Console.WriteLine("Unesite broj n: ");
        int n = int.Parse(Console.ReadLine());

        int fibN = CalculateFibonacci(n);

        Console.WriteLine("n-ti član Fibonačijevog niza je: " + fibN);
    }

    static int CalculateFibonacci(int n)
    {
        if (n <= 0)
            return 0;
        else if (n == 1)
            return 1;
        else
            return CalculateFibonacci(n - 1) + CalculateFibonacci(n - 2);
	}
}