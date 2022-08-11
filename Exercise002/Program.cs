//Задание: написать программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

int GetRandomNumber(int min, int max)
{
    return new Random().Next(min, max + 1);
}

int randomNumber = GetRandomNumber(100, 999);
Console.WriteLine(randomNumber);

int firstDigit = randomNumber / 100;
int thirdDigit = randomNumber % 10;

string GetRest(int a, int b)
{
    string remain1 = a.ToString();
    string remain2 = remain1 + b.ToString();
    return remain2;
}

string rest = GetRest(firstDigit, thirdDigit);
Console.WriteLine(rest);