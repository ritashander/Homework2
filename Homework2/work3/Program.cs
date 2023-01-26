// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели от 1 до 7");
int dayWeek = Convert.ToInt32(Console.ReadLine());
if (dayWeek == 6)
{
    System.Console.WriteLine("Выходной");
}

else if (dayWeek == 7)
{
    System.Console.WriteLine("Выходной");
}

else
{
    System.Console.WriteLine("Не выходной");
}
