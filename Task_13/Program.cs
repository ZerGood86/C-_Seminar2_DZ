//Задача 13: 
//Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();

Console.WriteLine("Enter n");
int n = int.Parse(Console.ReadLine());//645
int count = 0;
int x = 1;

if( n > 99)
{   
    while(count < 2)
    {
        while(n / x > 0)
        {
            x = x * 10;
        }
        x = x / 10;
        n = n - n / x * x;
        count = count +1;
        x = 1;
    }
    while(n / x > 0)
        {
            x = x * 10;
        }
        x = x / 10;
        int y = n / x;
    Console.WriteLine("\n" + y);
}
else
    Console.WriteLine("\nDisplay no third digit");