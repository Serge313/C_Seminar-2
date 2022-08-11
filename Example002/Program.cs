int GetRandomNumber(int min, int max)
{
    return new Random().Next(min, max + 1);
}

int randomNumber = GetRandomNumber(10, 99);

Console.WriteLine(randomNumber);

int firstGigit = randomNumber / 10;
int secondDigit = randomNumber % 10;

int Max(int a, int b)
{
    int max = 0;
    if(a > b)
    {
        max = a;
    }
    else
    {
        max = b;
    }
    return max;
}

int maxDigit = Max(firstGigit, secondDigit);
Console.WriteLine(maxDigit);