using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Wybierz liczbę z przedziału 1-20, a ja ją zgadnę!");

        int dolnyPrzedzial = 1;
        int gornyPrzedzial = 20;
        int propozycja;

        do
        {
            propozycja = (dolnyPrzedzial + gornyPrzedzial) / 2;

            Console.WriteLine("Czy Twoja liczba to {0}? (Odpowiedz -1, jeśli jest mniejsza, 1 jeśli jest większa, zero jeśli zgadłem)", propozycja);

            int odpowiedz = int.Parse(Console.ReadLine());

            if (odpowiedz < 0)
            {
                gornyPrzedzial = propozycja - 1;
            }
            else if (odpowiedz > 0)
            {
                dolnyPrzedzial = propozycja + 1;
            }
            else
            {
                Console.WriteLine("Zgadłem! Twoja liczba to {0}.", propozycja);
            }
        }
        while (propozycja != 0);
    }
}