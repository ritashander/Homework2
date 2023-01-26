// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int result = -1;
if(num >= 100)
{
    while (num > 999)
    {
        num = num / 10;
    }
    result = num % 10;
   System.Console.WriteLine(result); 
}
else if(num < 100)
{
    System.Console.WriteLine("Третьей цифры нет");
}


