
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

/*Console.WriteLine("Введите пятизначное число: ");
string str = Console.ReadLine();
char[]ch = str.ToCharArray();

if(str.ToCharArray().Length==5)
{
    Console.WriteLine("число введено верно");
}
else
{
    Console.WriteLine("число непятизначное");
}
{
if(ch[0] == ch[4] && ch[1] == ch[3])
{
    Console.WriteLine("палиндром");
}
else
{
    Console.WriteLine("не палиндром");
}

} */

//Напишите программу, которая принимает на
//вход координаты двух точек и находит расстояние между
//ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

/* Console.WriteLine("Введите координату первой точки x1: ");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату первой точки y1: ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату первой точки z1: ");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату первой точки x2: ");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату первой точки y2: ");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату первой точки z2: ");
int z2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x1-x2, 2)+ Math.Pow(y1-y2, 2)+ Math.Pow(z1-z2, 2));
Console.WriteLine(result); */

// Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

int count = 1;
while (count<= n)
{
    Console.Write(Math.Pow(count, 3) + "  ");
    count++;
}