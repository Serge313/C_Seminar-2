void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 201);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int CountNeeded(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] < 100)
            counter++;
    }
    return counter;
}

int[] numbers = new int[123];
FillArrayRandomNumbers(numbers);
int result = CountNeeded(numbers);
PrintArray(numbers);
Console.Write($"\nВ заданном массиве {result} чисел от 10 до 99");