// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


using System.Linq;

string text = " 1, 2, 5, 7, 19 "
              .Replace(" ","[")
              .Replace(" ","]")
              ;
Console.WriteLine(text);
var data = text.Split(" ") // вместо var можем прописать string[]
                .Select(item => item.Split(','))
                //.Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
                .ToArray();

for (int i = 0; i < data.Length; i++)
{
    
    for (int k = 0; k < data[i].Length; k++)
    {
        Console.WriteLine(data[i] [k]);
    }
    
    // Console.WriteLine(data[i]);
    // Console.WriteLine();
}
