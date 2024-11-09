using System;

class Program
{
    static void Main()
    {
        // KWADRAT
        Console.Write("Podaj długość boku kwadratu (liczba całkowita): ");
        int squareSide = int.Parse(Console.ReadLine());  // długość boku kwadratu
        int squareArea = squareSide * squareSide;        // pole kwadratu
        int squarePerimeter = 4 * squareSide;            // obwód kwadratu

        // PROSTOKĄT
        Console.Write("Podaj długość prostokąta (liczba całkowita): ");
        int rectangleLength = int.Parse(Console.ReadLine());  // długość prostokąta
        Console.Write("Podaj szerokość prostokąta (liczba całkowita): ");
        int rectangleWidth = int.Parse(Console.ReadLine());   // szerokość prostokąta
        int rectangleArea = rectangleLength * rectangleWidth; // pole prostokąta
        int rectanglePerimeter = 2 * (rectangleLength + rectangleWidth); // obwód prostokąta

        // TRÓJKĄT
        Console.Write("Podaj długość podstawy trójkąta (liczba zmiennoprzecinkowa): ");
        double triangleBase = double.Parse(Console.ReadLine());  // podstawa trójkąta
        Console.Write("Podaj wysokość trójkąta (liczba zmiennoprzecinkowa): ");
        double triangleHeight = double.Parse(Console.ReadLine()); // wysokość trójkąta
        double triangleArea = 0.5 * triangleBase * triangleHeight; // pole trójkąta

        // KOŁO
        Console.Write("Podaj promień koła (liczba zmiennoprzecinkowa): ");
        double circleRadius = double.Parse(Console.ReadLine());  // promień koła
        double circleArea = Math.PI * Math.Pow(circleRadius, 2); // pole koła
        double circleCircumference = 2 * Math.PI * circleRadius; // obwód koła

        // TRAPEZ
        Console.Write("Podaj długość podstawy a trapezu (liczba zmiennoprzecinkowa): ");
        double trapezoidBaseA = double.Parse(Console.ReadLine()); // podstawa a trapezu
        Console.Write("Podaj długość podstawy b trapezu (liczba zmiennoprzecinkowa): ");
        double trapezoidBaseB = double.Parse(Console.ReadLine()); // podstawa b trapezu
        Console.Write("Podaj wysokość trapezu (liczba zmiennoprzecinkowa): ");
        double trapezoidHeight = double.Parse(Console.ReadLine()); // wysokość trapezu
        double trapezoidArea = 0.5 * (trapezoidBaseA + trapezoidBaseB) * trapezoidHeight; // pole trapezu

        // WYŚWIETLANIE WYNIKÓW
        Console.WriteLine("\n=== Wyniki obliczeń ===");

        // Wyniki dla kwadratu
        Console.WriteLine("Długość boku kwadratu: {0}", squareSide);
        Console.WriteLine("Pole kwadratu = {0,-10} Obwód kwadratu = {1,10}", squareArea, squarePerimeter);

        // Wyniki dla prostokąta
        Console.WriteLine("\nDługość prostokąta: {0} Szerokość prostokąta: {1}", rectangleLength, rectangleWidth);
        Console.WriteLine($"Pole prostokąta = {rectangleArea,-10} Obwód prostokąta = {rectanglePerimeter,10}");

        // Wyniki dla trójkąta
        Console.WriteLine("\nPodstawa trójkąta: {0:F2} Wysokość trójkąta: {1:F2}", triangleBase, triangleHeight);
        Console.WriteLine($"Pole trójkąta: {triangleArea:F2}");

        // Wyniki dla koła
        Console.WriteLine("\nPromień koła: {0:F2}", circleRadius);
        Console.WriteLine("Pole koła = {0,10:F3} Obwód koła = {1,10:F3}", circleArea, circleCircumference);

        // Wyniki dla trapezu
        Console.WriteLine("\nDługość podstawy a trapezu: {0:F2} Długość podstawy b trapezu: {1:F2} Wysokość trapezu: {2:F2}", trapezoidBaseA, trapezoidBaseB, trapezoidHeight);
        Console.WriteLine("Pole trapezu = {0,-10:F4}", trapezoidArea);
    }
}