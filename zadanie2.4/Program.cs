namespace zadanie2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swoją średnia ocen a ja sprawdzę przysługującą kwote stypendium");
            double srednia = double.Parse(Console.ReadLine());
            if (srednia >= 2.00 && srednia <= 4.00)
            {
                Console.WriteLine("Nie przeysługuje Ci stypendium");
            }
            if (srednia >= 4.01 && srednia <= 4.80)
            {
                Console.WriteLine("Przysługuje Ci 300,00 zł stypendium");

            }
            if (srednia >= 4.81 && srednia <= 5.00)
                {
                Console.WriteLine("Przysługuje Ci 600,00 zł stypendium");
            }

        }
    }
}
