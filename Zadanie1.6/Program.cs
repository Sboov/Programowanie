namespace LiczenieDlugosciOdcinka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w programie do liczenia długości odcinków pomiędzy 2 punktami na płaszczyźnie.\nPodaj współrzędne punktu A (X oraz Y): ");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj teraz współrzędne punktu B (X oraz Y)");
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());

            double Result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));    //Math.Pow() sluzy do potegowania (double coś_tam = Math.Pow(X, Y)
                                                                                       //gdzie X to liczba, którą chcemy podnieść do potęgi a Y to liczba
                                                                                       //do której chcemy podnieść podstawe. Przykłady double result = Math.pow(2,3) to nic innego jak 2^3
                                                                                       //Math.Sqrt słuzy do obliczania pierwiastka kwadratowego z liczby. (double coś_tam = Matth.Sqrt(X)
                                                                                       //gdzie X to pierwiastek
            Console.WriteLine("Długość odcinka o punkcie A, którego współrzędne wynoszą X = {0} oraz Y = {1} oraz punktu B ze współrzędnymi X = {2} oraz {3} wynosi {4:F2}", x1, y1, x2, y2, Result); //wynik formatuje sie do dwóch miejsc po przecinku



        }
    }
}
//sprawdzic ujemny wynik