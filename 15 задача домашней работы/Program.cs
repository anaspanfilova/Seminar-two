// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine("Введите число от 1 до 7: ");
int day = int.Parse(Console.ReadLine()!);
if (day == 6)
{
   Console.WriteLine("Да"); 
}
else if (day == 7)
{
   Console.WriteLine("Да"); 
}
else if (1 < day && day < 6)
{
    Console.WriteLine("Нет");
}
else
{
   Console.WriteLine("Пробуй другое число");
}