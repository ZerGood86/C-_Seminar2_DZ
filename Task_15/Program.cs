//Задача 15: Напишите программу, которая принимает на вход
//цифру, обозначающую день недели, и проверяет, является ли
//этот день выходным.
//6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Enter day №");
int n = int.Parse(Console.ReadLine());

if(n > 0 && n < 8)
{
    if(n > 5)
        Console.WriteLine("Day off");
    else
        Console.WriteLine("Workday");
}
else
    Console.WriteLine("Error");
