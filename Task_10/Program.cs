//Задача 10: Напишите программу, которая принимает на вход
//трёхзначное число и на выходе показывает вторую цифру
//этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();

Console.WriteLine("Enter n");
int n = int.Parse(Console.ReadLine()!);

if(n > 99 && n < 1000)
{
    int a = (n - n / 100 * 100)/10;
    Console.WriteLine(a);
}
else
{
    Console.WriteLine("\nError");
}