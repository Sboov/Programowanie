using System;

class Program
{
    static void Main()
    {
        // KWADRAT
        Console.Write("Podaj długość boku kwadratu (liczba całkowita): ");
        int a = int.Parse(Console.ReadLine());
        int poleKwadratu = a * a;
        int obwodKwadratu = 4 * a;

        // PROSTOKĄT
        Console.Write("Podaj długość prostokąta (liczba całkowita): ");
        int dlugosc = int.Parse(Console.ReadLine());
        Console.Write("Podaj szerokość prostokąta (liczba całkowita): ");
        int szerokosc = int.Parse(Console.ReadLine());
        int poleProstokata = dlugosc * szerokosc;
        int obwodProstokata = 2 * (dlugosc + szerokosc);

        // TRÓJKĄT
        Console.Write("Podaj długość podstawy trójkąta (liczba zmiennoprzecinkowa): ");
        double podstawa = double.Parse(Console.ReadLine());
        Console.Write("Podaj wysokość trójkąta (liczba zmiennoprzecinkowa): ");
        double wysokosc = double.Parse(Console.ReadLine());
        double poleTrojkata = 0.5 * podstawa * wysokosc;

        // KOŁO
        Console.Write("Podaj promień koła (liczba zmiennoprzecinkowa): ");
        double promien = double.Parse(Console.ReadLine());
        double poleKola = Math.PI * Math.Pow(promien, 2);
        double obwodKola = 2 * Math.PI * promien;

        // TRAPEZ
        Console.Write("Podaj długość podstawy a trapezu (liczba zmiennoprzecinkowa): ");
        double podstawaA = double.Parse(Console.ReadLine());
        Console.Write("Podaj długość podstawy b trapezu (liczba zmiennoprzecinkowa): ");
        double podstawaB = double.Parse(Console.ReadLine());
        Console.Write("Podaj wysokość trapezu (liczba zmiennoprzecinkowa): ");
        double wysokoscTrapezu = double.Parse(Console.ReadLine());
        double poleTrapezu = 0.5 * (podstawaA + podstawaB) * wysokoscTrapezu;

        // WYPISYWANIE WYNIKÓW NA KOŃCU
        Console.WriteLine("\n=== Wyniki obliczeń ===");

        // Wyniki dla kwadratu
        Console.WriteLine("Długość boku kwadratu: {0}", a);
        Console.WriteLine("Pole kwadratu = {0,-10} Obwód kwadratu = {1,10}", poleKwadratu, obwodKwadratu);

        // Wyniki dla prostokąta
        Console.WriteLine("\nDługość prostokąta: {0} Szerokość prostokąta: {1}", dlugosc, szerokosc);
        Console.WriteLine($"Pole prostokąta = {poleProstokata,-10} Obwód prostokąta = {obwodProstokata,10}");

        // Wyniki dla trójkąta
        Console.WriteLine("\nPodstawa trójkąta: {0:F2} Wysokość trójkąta: {1:F2}", podstawa, wysokosc);
        Console.WriteLine($"Pole trójkąta: {poleTrojkata:F2}");

        // Wyniki dla koła
        Console.WriteLine("\nPromień koła: {0:F2}", promien);
        Console.WriteLine("Pole koła = {0,10:F3} Obwód koła = {1,10:F3}", poleKola, obwodKola);

        // Wyniki dla trapezu
        Console.WriteLine("\nDługość podstawy a trapezu: {0:F2} Długość podstawy b trapezu: {1:F2} Wysokość trapezu: {2:F2}", podstawaA, podstawaB, wysokoscTrapezu);
        Console.WriteLine("Pole trapezu = {0,-10:F4}", poleTrapezu);
    }
}