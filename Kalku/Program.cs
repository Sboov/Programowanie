using System;

namespace Kalku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Witaj w prostym kalkulatorze!");
            Console.WriteLine("Program umożliwia wykonanie operacji dodawania, odejmowania, mnożenia oraz dzielenia na dwóch liczbach rzeczywistych.");

            
            Console.WriteLine("Podaj pierwszą liczbę:");
            double a = double.Parse(Console.ReadLine());

            
            Console.WriteLine("Wybierz operację, którą chcesz wykonać:");
            Console.WriteLine("'+' by dodać\n'-' by odjąć\n'*' by mnożyć\n'/' by dzielić");
            string wybor = Console.ReadLine();

            
            if (wybor != "+" && wybor != "-" && wybor != "*" && wybor != "/")
            {
                Console.WriteLine("Podałeś zły symbol operacji! Spróbuj ponownie uruchamiając program.");
                return;
            }

            
            Console.WriteLine("Podaj drugą liczbę:");
            double b = double.Parse(Console.ReadLine());

            
            switch (wybor)
            {
                case "+":
                    double wynikDodawania = a + b;
                    Console.WriteLine("Wynik dodawania: {0}", wynikDodawania);
                    break;

                case "-":
                    double wynikOdejmowania = a - b;
                    Console.WriteLine("Wynik odejmowania: {0}", wynikOdejmowania);
                    break;

                case "*":
                    double wynikMnożenia = a * b;
                    Console.WriteLine("Wynik mnożenia: {0}", wynikMnożenia);
                    break;

                case "/":
                    try
                    {
                        
                        if (b == 0)
                        {
                            throw new DivideByZeroException("Błąd: nie można dzielić przez zero!");
                        }

                        double wynikDzielenia = a / b;
                        Console.WriteLine("Wynik dzielenia: {0}", wynikDzielenia);
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
            }
        }
    }
}
