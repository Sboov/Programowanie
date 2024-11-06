using System;

namespace Kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulator pól oraz obwodów podstawowych figur geometrycznych\nDo wyboru masz:\n1 - Kwadrat\n2 - Trójkąt\n3 - Koło\n4 - Trapez\nWpisz liczbę całkowitę by wybrać figurę: ");
            ConsoleKeyInfo button = Console.ReadKey();
            Console.WriteLine();
            if (button.Key == ConsoleKey.D1)
            {
                Console.WriteLine("Wybrałeś kwadrat. Teraz wybierz co chcesz obliczyć:\n1 - Pole\n2 - Obwód  ");
                ConsoleKeyInfo choice = Console.ReadKey();
                Console.WriteLine();
                if (choice.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("Wybrałeś liczenie pola kwadratu. Podaj X: ");
                    double x = double.Parse(Console.ReadLine());
                    double result = x * x;
                    ResultChecker("Pole kwadratu wynosi: ", result); //1 mozliwosc ukazania wyniku

                }
                else if (choice.Key == ConsoleKey.D2)
                {
                    Console.WriteLine("Wybrałeś liczenie obwodu kwadratu. Podaj X: ");
                    double x = double.Parse(Console.ReadLine());
                    double result = x * 4;
                    Console.WriteLine("Obwód kwadratu wynosi: {0}", result);  //inna mozliwosc pokazania wyniku
                }

            }
            else if (button.Key == ConsoleKey.D2)
            {
                Console.WriteLine("Wybrałeś Trójkąt. Teraz wybierz co chcesz obliczyć:\n1 - Pole\n2 - Obwód");
                ConsoleKeyInfo choice = Console.ReadKey();
                Console.WriteLine();
                if (choice.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("Wybrałeś liczenie pola trójkąta. Podaj A oraz H");
                    double a = double.Parse(Console.ReadLine());
                    double h = double.Parse(Console.ReadLine());
                    double result = 0.5 * a * h;
                    ResultChecker("Pole trójkąta wynosi: ", result);


                }
                else if (choice.Key == ConsoleKey.D2)
                {
                    Console.WriteLine("Wybrałeś liczenie obwodu trójaktą. Podaj boki A, B oraz C");
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    double c = double.Parse(Console.ReadLine());
                    double result = a + b + c;
                    Console.WriteLine("Obwód trojkąta wynosi: {0}", result); //kolejna mozliwosc wskazania wyniku 
                }



            }
            else if (button.Key == ConsoleKey.D3)
            {
                Console.WriteLine("Wybrałeś Koło. Teraz wybierz co chcesz obliczyć:\n1 - Pole\n2 - Obwód");
                ConsoleKeyInfo choice = Console.ReadKey();
                Console.WriteLine();
                if (choice.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("Wybrałeś liczenie pola koła. Podaj teraz R:");
                    double r = double.Parse(Console.ReadLine());
                    double result = 3.14 * r * r;
                    ResultChecker("Pole koła wynosi: ", result);
                }

                else if (choice.Key == ConsoleKey.D2)
                {
                    Console.WriteLine("Wybrałeś liczenie obwodu koła. Podaj teraz R:");
                    double r = double.Parse(Console.ReadLine());
                    double result = 2 * 3.14 * r;
                    ResultChecker("Obwód koła wynosi: ", result);
                }




            }
            else if (button.Key == ConsoleKey.D4)
            {
                Console.WriteLine("Wybrałeś Trapez. Teraz wybierz co chcesz obliczyć: \n1 - Pole\n2 - Obwód");
                ConsoleKeyInfo choice = Console.ReadKey();
                Console.WriteLine();
                if (choice.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("Wybrałeś liczenie pola trapeza. Podaj A, B oraz H");
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    double h = double.Parse(Console.ReadLine());
                    double result = ((a + b) / 2) * h;
                    ResultChecker("Pole trapezu wynosi: ", result);


                }
                else if (choice.Key == ConsoleKey.D2)
                {
                    Console.WriteLine("Wybrałeś liczenie obwodu trapeza. Podaj A, B, C, D");
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    double c = double.Parse(Console.ReadLine());
                    double d = double.Parse(Console.ReadLine());
                    double result = a + b + c + d;
                    Console.WriteLine("Obwód trapezu składającego się z boków: A: {0} B: {1} C: {2} D: {3} wynosi: {4}", a, b, c, d, result);
                }
            }
            else if (button.Key == ConsoleKey.D5)
            {
                Console.WriteLine("Wybrałeś Prostokąt. Teraz wybierz co chcesz obliczyć: \n1 - Pole\n2 - Obwód");
                ConsoleKeyInfo choice = Console.ReadKey();
                Console.WriteLine();
                if (choice.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("Wybrałeś liczenie pola prostokąta. Podaj A oraz B");
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    double result = a * b;
                    ResultChecker("Pole prostokąta wynosi wynosi: ", result);


                }
                else if (choice.Key == ConsoleKey.D2)
                {
                    Console.WriteLine("Wybrałeś liczenie obwodu prostokąta. Podaj A oraz B");
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    double result = (a * 2) + (b * 2);
                    ResultChecker("Obwód prostokąta wynosi: {0}", result);
                }
            }
        }
        static void ResultChecker(string message, double result)
        {
            if (result % 1 == 0)     //sprawdzamy czy wynik jest całkowita czy zmienno przecinkowa
            {
                Console.WriteLine($"{message}{Convert.ToInt32(result)}"); //jeśli jest liczbą całkowitą to konwertujemy i wyświetlamy bez miejsca po przecinku

            }
            else
            {
                Console.WriteLine($"{message}{result:F2}");  //w innym wypadku wynik wyświetlamy z dokładnościa do dwóch miejsc po przecinku. "F2" odpowiada za liczbe miejsc po przecinku.
            }

        }

    }
}
