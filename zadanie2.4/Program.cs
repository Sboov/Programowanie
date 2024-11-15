namespace zadanie2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swoją średnią ocen, a ja sprawdzę przysługującą kwotę stypendium");
            double srednia = double.Parse(Console.ReadLine());

            
            if (srednia < 2.00)
            {
                Console.WriteLine("Nie przysługuje Ci stypendium");
            }
            else if (srednia >= 4.00 && srednia <= 4.80)
            {
                Console.WriteLine("Przysługuje Ci 300,00 zł stypendium");
            }
            else if (srednia > 4.80 && srednia <= 5.00)
            {
                Console.WriteLine("Przysługuje Ci 600,00 zł stypendium");
            }
            else
            {
                Console.WriteLine("Nie przysługuje Ci stypendium");
            }
        }
    }
}