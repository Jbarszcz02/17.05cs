using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Podaj liczbę n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Pary liczb naturalnych:");

        znajdzpary(n);
    }

    public static void znajdzpary(int n)
    {
        for (int i = 1; i <= n / 2; i++)
        {
            int j = n - i;
            Console.WriteLine("{0} + {1} = {2}", i, j, n);
        }
    }
}