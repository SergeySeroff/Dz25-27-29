// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void Stepen(int a, int b)
{
    double step = Math.Pow(a,b);
    Console.Write(step);
}

Console.Write("a=");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("b=");
int b = Convert.ToInt32(Console.ReadLine());

Stepen(a, b);