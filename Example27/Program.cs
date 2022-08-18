// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int[] CreatRendomArray(int size, int minValue, int maxValue)
{
    int [] newArray = new int[size]; // обязательная строка для выделения памяти!!!

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)  // название(метода или массив).Length <-- определит нашу длинну массива
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int SumPositive(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}
Console.Write("Imput size array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] binaryArray = CreatRendomArray(size, min, max);
ShowArray(binaryArray);

int sum = SumPositive(binaryArray);
Console.Write(sum);