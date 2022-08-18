// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


void Main(string[] args)
{
    int[] array = new int[8];
    Console.Write("Вывод массива: [");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
Console.Write("Введите массив чисел: ");
int element = int.Parse(Console.ReadLine());

Main(args);
Console.Write("]");