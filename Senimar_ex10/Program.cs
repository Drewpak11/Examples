//17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

/*Console.Clear();
Console.WriteLine("Введите координату x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y: ");
int y = Convert.ToInt32(Console.ReadLine());

if(x == 0 | y == 0) Console.WriteLine("Введите другую координату");
else if(x > 0 && y > 0) Console.WriteLine("Точка находиться в первой четверти"); 
else if(x < 0 && y > 0) Console.WriteLine("Точка находиться во второй четверти");
else if(x < 0 && y < 0) Console.WriteLine("Точка находиться в третьей четверти");
else if(x > 0 && y < 0) Console.WriteLine("Точка находить с четвертой четверти");*/

 //Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)

 /*Console.WriteLine("Введите номер четверти для определения возможных  координат");
 int num = Convert.ToInt32(Console.ReadLine());

 if(num == 1) Console.WriteLine("Координаты X > 0 и y > 0");
 else if(num == 2) Console.WriteLine("Координаты X < 0 и y > 0");
 else if(num == 3) Console.WriteLine("Координаты X < 0 и y < 0");
 else if(num == 4) Console.WriteLine("Координаты X > 0 и y < 0");
 else if(num < 1 | num > 4) Console.WriteLine("Такой четверти нет!");*/

  //Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

  Console.WriteLine("Введите координату x для первой точки: ");
  int xa = Convert.ToInt32(Console.ReadLine());

  Console.WriteLine("Введите координату y для первой точки: ");
  int ya = Convert.ToInt32(Console.ReadLine());

  Console.WriteLine("Введите координату x для второй точки: ");
  int xb = Convert.ToInt32(Console.ReadLine());

  Console.WriteLine("Введите координату y для второй точки: ");
  int yb = Convert.ToInt32(Console.ReadLine());

  double z = Math.Sqrt((xb - xa)^2 + (yb - ya)^2);
  Console.WriteLine($"Расстояние между точками {z}");

   /*Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4*/

/*Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
int x = 1;


while(count <= num)
{
    x = count * count * count;
    count++;
    Console.Write($"{x},");
}*/




