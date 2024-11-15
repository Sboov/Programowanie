namespace _2._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int liczba1, liczba2, liczba3;

            try
            {
                Console.WriteLine("Podaj pierwszą liczbę całkowtią rózną od 0");
                liczba1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Podaj drugą liczbę całkowitą różną od 0");
                liczba2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Podaj trzecią liczbę całkowtią różną od 0");
                liczba3 = int.Parse(Console.ReadLine());

                if (liczba1 == 0 || liczba2 == 0 || liczba3 == 0)
                {
                    throw new ArgumentException("liczby muszą być różne od 0.");

                }
                int najwieksza = Math.Max(liczba1, Math.Max(liczba2, liczba3)); //Math.Max zarowno jak Math.Min porownuja tylko dwa argumenty liczbowe.
                                                                                //Wiec jesli chcemy porownac zbior 3 liczb musimy porownac najpierw zbior dwoch liczb (liczby 2 i 3). Wyloniona najwieksza liczba z tego
                                                                                //zbioru bedzie porownywana z liczba1.
                int najmniejsza = Math.Min(liczba1, Math.Min(liczba2, liczba3));

                Console.WriteLine("Najwieksza liczba to: {0}", najwieksza);

  Console.WriteLine($"Najmniejsza liczba to: {najmniejsza}");

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Podaj liczbę całkowitą");
            }

        }
    }
}
