//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int a = num % 10;
if (a = num % 10)
{
 Console.WriteLine($"Вторая цифра числа {num} -> {a}");   
}
else
{
 Console.WriteLine($"Третьей цифры нет");
}
