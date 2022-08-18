// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


int[] CreatRendomArray(int size, int minValue, int maxValue)

{
    int [] newArray = new int[size]; // обязательная строка для выделения памяти!!!

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)  // название(метода, массива пофиг чего надо).Length <-- определит нашу длинну массива
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] MinusArray(int[] array)
{
    for(int i =0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }
    return array;
}

Console.Write("Imput size array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreatRendomArray(size, min, max);
ShowArray(array);

array = MinusArray(array);
ShowArray(array);
