int GetRandomNumber(int min, int max)
{
    return new Random().Next(min, max + 1);
}

int randomNumber = GetRandomNumber(100, 999);
Console.WriteLine(randomNumber);

int rest = randomNumber % 100;

Console.WriteLine(rest);