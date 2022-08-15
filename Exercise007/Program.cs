double firstDotFirstCoordinate = GetNumber("Enter the first coordinate of the first dot ");
double firstDotSecondCoordinate = GetNumber("Enter the second coordinate of the first dot ");
double secondDotFirstCoordinate = GetNumber("Enter the first coordinate of the second dot ");
double secondDotSecondCoordinate = GetNumber("Enter the second coordinate of the second dot ");
double firstCathetus = Cathetus(firstDotFirstCoordinate, secondDotFirstCoordinate);
double secondCathetus = Cathetus(firstDotSecondCoordinate, secondDotSecondCoordinate);
double distance = Distance(firstCathetus, secondCathetus);
Console.WriteLine("A (" + firstDotFirstCoordinate + "," + firstDotSecondCoordinate + "); B (" + secondDotFirstCoordinate + "," + secondDotSecondCoordinate + ") -> " + distance);


/* Предыдущая строка написанная с помощью интерполяции:
Console.WriteLine($"A({firstDotFirstCoordinate}, {firstDotSecondCoordinate}); B({secondDotFirstCoordinate}, {secondDotSecondCoordinate}) -> {distance}"); */


double Cathetus(double a, double b)
{
    double cathetus = (b - a);
    return cathetus;
}


double Distance(double a, double b)
{
    double c = Math.Sqrt((a * a) + (b * b));
    return c;
}


double GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}