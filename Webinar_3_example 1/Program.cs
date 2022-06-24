/* Напишите программу, которая на вход принимает координаты точки (X, Y), причем X не равен 0 и Y не равен 0 
и выдает номер четверти плоскости, в которой находится эта точка*/

/*Console.WriteLine("Введите х: ");
int x = int.Parse(Console.ReadLine());  //возможность ввести с клавиатуры значение

Console.WriteLine("Введите y: ");
int y = int.Parse(Console.ReadLine());

if(x > 0 && y > 0) // && логическое И 
{
    Console.WriteLine("Первая плоскость");
}
else if(x < 0 && y > 0)
{
    Console.WriteLine("Вторая плоскость");
}
else if(x < 0 && y < 0)
{
    Console.WriteLine("Третья плоскость");
}
else if(x > 0 && y < 0)
{
    Console.WriteLine("Четвертая плоскость");
}
else
{
    Console.WriteLine("Не принадлежит ни одной плоскости");
}
*/

// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат
//точек в этой четверти (x и y)

/*Console.WriteLine("Введите номер четверти: ");
int x = int.Parse(Console.ReadLine());

if(x == 1)
{
    Console.WriteLine("x > 0 && y > 0");
}
else if(x == 2)
{
    Console.WriteLine("x < 0 && y < 0");
}
else if(x == 3)
{
    Console.WriteLine("x > 0 && y < 0");
}
else if(x == 4)
{
    Console.WriteLine("x > 0 && y < 0");
}
else
{
  Console.WriteLine("нет такой плоскости");  
}
*/

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 2D пространстве.
// А(3,6); В(2,1)-> 5,09
// A(7,5); B(1,-1)-> 7,21

/*Console.WriteLine("Введите координату первой точки x1: ");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату первой точки y1: ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату первой точки x2: ");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату первой точки y2: ");
int y2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x1-x2, 2)+ Math.Pow(y1-y2, 2));
Console.WriteLine(result);*/


// Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N.
// 5-> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

int count = 1;
while (count<= n)
{
    Console.Write(Math.Pow(count, 2) + "  ");
    count++;
}


