using System;

public class Program
{
    public static long Silnia(int number)
    {
        long result = 1;

        for (int i = 2; i <= number; i++)
        {
            result *= i;
        }

        return result;
    }

    public static void Main()
    {
        int n, k;
        do
        {
            Console.Write("Podaj liczbę n: ");
        } while (!int.TryParse(Console.ReadLine(), out n) || n < 5);

        do
        {
            Console.Write("Podaj liczbę k: ");
        } while (!int.TryParse(Console.ReadLine(), out k) || k < 5);

        long licznik = Silnia(n) - Silnia(k);
        long mianownik = Silnia(k);

        long wynik = licznik / mianownik;

        Console.WriteLine($"Wartość m wynosi: {wynik}");
    }
}