int x = GetNumber("Enter your X ");
int y = GetNumber("Enter your Y ");

if (x == 0 || y == 0)
{
    Console.WriteLine("Enter X and Y, wich are not equal to zero");
    return;
}

if (x > 0 && y > 0)
{
    Console.WriteLine("The dot is in the first quarter");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("The dot is in the second quarter");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("The dot is in the third quarter");
}
else
{
    Console.WriteLine("The dot is in the fourth quarter");
}

int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}