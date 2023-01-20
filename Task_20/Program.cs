// Задача №20. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.  A (3,6); B (2,1) -> 5,09  A (7,-5); B (1,-1) -> 7,21

// Console.WriteLine("Введите координаты точки 1: ");

// string[] sArr = Console.ReadLine().Split(' ');
// int num1 = Convert.ToInt32(sArr[0]);
// int num2 = Convert.ToInt32(sArr[1]);

// Console.WriteLine("Введите координаты точки 2: ");

// string[] sArr2 = Console.ReadLine().Split(' ');
// int num3 = Convert.ToInt32(sArr2[0]);
// int num4 = Convert.ToInt32(sArr2[1]);

// double result = Math.Round(Math.Sqrt(Math.Pow((num3 - num1), 2)+ Math.Pow((num4 - num2),2)), 3);
// Console.Write(result);


// Console.WriteLine("Input number of quarter:");
// int quarter = Convert.ToInt32(Console.ReadLine());

Random rand = new Random();

int x1 = rand.Next(-100, 101), y1 = rand.Next(-100, 101);
int x2 = rand.Next(-100, 101), y2 = rand.Next(-100, 101);

Console.WriteLine($"Point A  ({x1}, {y1})");
Console.WriteLine($"Point B  ({x2}, {y2})");

double length = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
Console.WriteLine(Math.Round(length,2));