using System;

public class Program
{
    public static void Main()
    {
        decimal sumpocz;
        decimal oprocentowanie;
        int miesiace;

        do
        {
            Console.Write("Podaj kwotę początkową: ");
        } while (!decimal.TryParse(Console.ReadLine(), out sumpocz) || sumpocz < 0);

        do
        {
            Console.Write("Podaj oprocentowanie konta w skali roku: ");
        } while (!decimal.TryParse(Console.ReadLine(), out oprocentowanie) || oprocentowanie < 0);

        do
        {
            Console.Write("Podaj liczbę miesięcy oszczędzania: ");
        } while (!int.TryParse(Console.ReadLine(), out miesiace) || miesiace < 0);

        decimal miesoprocentowanie = oprocentowanie / 12 / 100;
        decimal suma = sumpocz * (decimal)Math.Pow(1 + (double)miesoprocentowanie, miesiace);

        decimal belkaTax = suma * (decimal)0.19;
        decimal sumatax = suma - belkaTax;

        Console.WriteLine($"Wartość końcowa oszczędności po opodatkowaniu Belką: {sumatax}");
    }
}