// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа
// 456 -> 5
// 782 -> 8
// 918 -> 1

/* int a = 768;
string str = a.ToString();
Console.WriteLine(str[1]);*/

// Напишите программу, которая принимает на вход цифру, обозначающую день недели и проверяет,
// является ли этот день выходным
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("введите номер дня недели");
string str = Console.ReadLine();
int num = int.Parse(str);
int [] array = { 1, 2, 3, 4, 5, 6, 7 };

if(num == array [5])
{
Console.WriteLine("выходной");
}

if(num == array [6])
{
Console.WriteLine("выходной");
}
else
{
    Console.WriteLine("рабочий день");
}