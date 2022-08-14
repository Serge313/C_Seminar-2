int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int number = GetNumber("Введите число ");


if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("Yep");
} 
else
{
    Console.WriteLine("Nope");
}
