//Задание: написать программу, которая будет принимать на вход два числа и выводить является ли первое число кратным второму.

int GetRandomNumber(int min, int max)
{
    return new Random().Next(min, max + 1);
}

int firstRandomNumber = GetRandomNumber(1, 999);
int secondRandomNumber = GetRandomNumber(1, 999);

Console.WriteLine(firstRandomNumber);
Console.WriteLine(secondRandomNumber);

int GetAliquot(int a, int b)
{
    int remain = 0;
    if(a % b == 0)
    {
        remain = 0;
        Console.WriteLine("Кратно");
    }
    else if(a < b)
    {
        Console.WriteLine("Error!!!");
    }
    else
    {
        remain = a % b;
        Console.WriteLine("Не кратно, остаток " + remain);
    }

    return remain;
}

int result = GetAliquot(firstRandomNumber, secondRandomNumber);
