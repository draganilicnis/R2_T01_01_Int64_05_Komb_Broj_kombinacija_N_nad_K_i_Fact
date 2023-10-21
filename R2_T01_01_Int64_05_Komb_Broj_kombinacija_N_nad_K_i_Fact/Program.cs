// https://petlja.org/biblioteka/r/Zbirka2/broj_kombinacija
// https://arena.petlja.org/competition/r1-04-metode-01-staticke-metode#tab_132244

using System;

class Broj_kombinacija_N_nad_K_Ver_000
{
    static int fakt(int n)
    {
        int p = 1;
        for (int i = 2; i <= n; i++)
        {
            p = p * i;
        }
        return p;
    }
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int c = fakt(n) / (fakt(n - k) * fakt(k));
        Console.WriteLine(c);
    }
}