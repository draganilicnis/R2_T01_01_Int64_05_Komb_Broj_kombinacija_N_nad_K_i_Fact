# R2_T01_01_Int64_05_Komb_Broj_kombinacija_N_nad_K_i_Fact

Primer prekoračenja maksimalne vrednosti celobrojnog tipa podataka int (zbog faktorijela n!):

Broj kombinacija n nad k = faktorijel(n) / ( faktorijel (n-k) / faktorijel (k) )

Za ulazne vrednosti malih brojeva programski kod izračunava ispravne i tačne izlazne vrednosti:
Ulaz:
3
5
Izlaz:
10

Međutim za nešto veće vrednosti ulaznih vrednosti:
7
39

Prijavljuje grešku zbog deljenja nulom!

Od 10 komisijskih test primera na https://petlja.org/biblioteka/r/Zbirka2/broj_kombinacija, prolazi samo jedan (test primer 5), dok za ostale prijavljuje gresku WA ili RTE:
https://dragilic.files.wordpress.com/2023/10/r2_t01_01_int64_05_komb_broj_kombinacija_n_nad_k_i_fact_ver_000.png

---------------------------------------------------------------------
Verzija 000
---------------------------------------------------------------------
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
