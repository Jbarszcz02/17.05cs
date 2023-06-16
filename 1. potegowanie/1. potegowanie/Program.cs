using System;

public class Program
{
    public static int pot(int n1, int potega)
    {
        int result = 1;

        for (int i = 0; i < potega; i++)
        {
            result *= n1;
        }

        return result;
    }

    public static void Main()
    {
        int n1 = 2;
        int potega = 5;
        int result = pot(n1, potega);

        Console.WriteLine($"Wynik potęgowania: {result}");
    }
}