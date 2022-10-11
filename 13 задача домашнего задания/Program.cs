//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int x = num / 10;
int y = x;
if (x >= 10 || x < -10)
{
    while (num > 999 || num < -999)
    {
        num = num / 10;
    }
    if (num < 0)
    {
        num = -num;
        Console.WriteLine($"Вторая цифра числа {y} -> {(num % 10)}"); 
    }
    else
    {
      Console.WriteLine($"Вторая цифра числа {y} -> {(num % 10)}");   
    }
}
else
{
    Console.WriteLine($"Третьей цифры нет");
}