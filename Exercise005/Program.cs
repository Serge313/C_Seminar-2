int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int number1 = GetNumber("Enter your first number ");
int number2 = GetNumber("Enter your second number ");


if (number1 * number1 == number2 || number2 * number2 == number1)
{
    Console.WriteLine("Yep");
}
else
{
    Console.WriteLine("Nope");
} 