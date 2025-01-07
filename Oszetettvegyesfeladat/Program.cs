using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> lista = listaszules();
        lista = Feltolt(lista);

        List<int> negyzetLista = Negyzet(lista);
        Console.WriteLine("A lista elemeinek négyzetei: " + string.Join(", ", negyzetLista));

        int osszeg = LOsszeg(lista);
        Console.WriteLine("A lista elemeinek összege: " + osszeg);

        List<int> parosLista = paros(lista);
        Console.WriteLine("A lista páros elemei: " + string.Join(", ", parosLista));

        List<int> szorzottLista = Elemszorzas(lista, 3);
        Console.WriteLine("A lista elemeinek háromszorosa: " + string.Join(", ", szorzottLista));

        List<int> osszefesultLista = fesul(lista, new List<int> { 11, 12, 13 });
        Console.WriteLine("Összefésült lista: " + string.Join(", ", osszefesultLista));

        int legnagyobb = Legnagyobb(lista);
        Console.WriteLine("A lista legnagyobb eleme: " + legnagyobb);

        int legkisebb = Legkisebb(lista);
        Console.WriteLine("A lista legkisebb eleme: " + legkisebb);

        bool mindenParos = MindenElemParos(lista);
        Console.WriteLine("Minden elem páros? " + mindenParos);

        List<int> masodikElemek = masodik(lista);
        Console.WriteLine("A lista minden második eleme: " + string.Join(", ", masodikElemek));

        List<int> forditottLista = Forditott(lista);
        Console.WriteLine("A lista fordított sorrendben: " + string.Join(", ", forditottLista));

        List<string> nagybetusLista = NagyKezdobetu(new List<string> { "anna", "bÉla", "áDáM" });
        Console.WriteLine("Nagy kezdőbetűvel írt lista: " + string.Join(", ", nagybetusLista));

        List<string> hosszabbMint5Lista = HosszabbMint5(new List<string> { "alma", "banán", "szilva", "eper", "sárgadinnye" });
        Console.WriteLine("5 karakternél hosszabb szavak: " + string.Join(", ", hosszabbMint5Lista));
    }

    static List<int> listaszules() => new List<int>();

    static List<int> Feltolt(List<int> lista)
    {
        for (int i = 1; i <= 10; i++)
            lista.Add(i);
        return lista;
    }

    static List<int> Negyzet(List<int> lista)
    {
        List<int> eredmeny = new List<int>();
        foreach (int szam in lista)
            eredmeny.Add(szam * szam);
        return eredmeny;
    }

    static int LOsszeg(List<int> lista) => lista.Sum();

    static List<int> paros(List<int> lista)
    {
        List<int> eredmeny = new List<int>();
        foreach (int szam in lista)
            if (szam % 2 == 0)
                eredmeny.Add(szam);
        return eredmeny;
    }

    static List<int> Elemszorzas(List<int> lista, int szorzo)
    {
        List<int> eredmeny = new List<int>();
        foreach (int szam in lista)
            eredmeny.Add(szam * szorzo);
        return eredmeny;
    }

    static List<int> fesul(List<int> lista1, List<int> lista2)
    {
        List<int> eredmeny = new List<int>();
        int hossz = Math.Max(lista1.Count, lista2.Count);
        for (int i = 0; i < hossz; i++)
        {
            if (i < lista1.Count) eredmeny.Add(lista1[i]);
            if (i < lista2.Count) eredmeny.Add(lista2[i]);
        }
        return eredmeny;
    }

    static int Legnagyobb(List<int> lista) => lista.Max();

    static int Legkisebb(List<int> lista) => lista.Min();

    static bool MindenElemParos(List<int> lista)
    {
        foreach (int szam in lista)
            if (szam % 2 != 0)
                return false;
        return true;
    }

    static List<int> masodik(List<int> lista)
    {
        List<int> eredmeny = new List<int>();
        for (int i = 1; i < lista.Count; i += 2)
            eredmeny.Add(lista[i]);
        return eredmeny;
    }

    static List<int> Forditott(List<int> lista)
    {
        List<int> eredmeny = new List<int>(lista);
        eredmeny.Reverse();
        return eredmeny;
    }

    static List<string> NagyKezdobetu(List<string> lista)
    {
        List<string> eredmeny = new List<string>();
        foreach (string szoveg in lista)
            eredmeny.Add(char.ToUpper(szoveg[0]) + szoveg.Substring(1).ToLower());
        return eredmeny;
    }

    static List<string> HosszabbMint5(List<string> lista)
    {
        List<string> eredmeny = new List<string>();
        foreach (string szoveg in lista)
            if (szoveg.Length > 5)
                eredmeny.Add(szoveg);
        return eredmeny;
    }
}
