// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.Clear();
Console.WriteLine("Введите первое число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);
int result = number % number2;
if (number % number2 == 0)
{
Console.WriteLine($"Число {number} кратно {number2}");
}
else
{
   Console.WriteLine($"Число {number} не кратно {number2}, остаток - {result}"); 
}