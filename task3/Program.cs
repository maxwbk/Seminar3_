// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125



Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine("Таблица кубов чисел от 1 до {0}", N);
Console.WriteLine("------------------------------");

for (int i = 1; i <= N; i++)
{
    int cube = i * i * i;
    Console.WriteLine("{0}^3 = {1}", i, cube);
}

Console.ReadLine();

