int size = ReadInt("Укажите размер массива ");
int[] array = new int[size];
int number = ReadInt("Введите число которое нужно найти ");

FillArrayRandomNumbers(array);
bool isValid =  SearchNumber(array, number);

if (isValid == true)
{
    Console.Write("да");
}
else
{
    Console.Write("нет");
}

bool SearchNumber(int[] array1, int num)
{
    bool valid = false; 
    for (int i = 0; i < array1.Length; i++)
    {
        if (num == array1[i])
        {
            valid = true;
            break;
        }
       
    }
     
    return valid;
}


void FillArrayRandomNumbers(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = new Random().Next(0, 10);
        Console.Write(array1[i] + " ");
    }
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}