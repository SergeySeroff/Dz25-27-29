// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int SumNumb(int a)
{
    int s = 0;
    while (a > 0)
    {
        s = s + a % 10;
        a = a / 10;
    }
    return s;
}
Console.Write("Ввидите число: ");
int s = Convert.ToInt32(Console.ReadLine());

int fin = SumNumb(s);
Console.WriteLine(fin);