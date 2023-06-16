using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Podaj liczbę x: ");
        int x = int.Parse(Console.ReadLine());

        int n = lsilni(x);

        if (n != -1)
        {
            Console.WriteLine("Liczba jest silnią liczby {0}.", n);
        }
        else
        {
            Console.WriteLine("Liczba nie jest silnią żadnej liczby.");
        }
    }

    public static int lsilni(int x)
    {
        int n = 0;
        int silnia = 1;

        while (silnia <= x)
        {
            n++;
            silnia *= n;

            if (silnia == x)
            {
                return n;
            }
        }

        return -1;
    }
}