// Напишите программу, которая будет принимать на вход два числа и проверяет, является ли одно число квадратом другого.

Console.Clear();
Console.WriteLine("Введите первое число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);
if (number * number == number2)
{
Console.WriteLine($"Да");
}
else if (number2 * number2 == number)
{
   Console.WriteLine($"Да"); 
}
else
{
   Console.WriteLine($"нет"); 
}