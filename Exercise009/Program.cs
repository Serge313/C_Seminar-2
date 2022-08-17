/*Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 0;

while (number > 0)
{
    i++;
    number = number / 10;
}
Console.WriteLine(i);