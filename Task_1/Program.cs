// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя)
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = number*number;

// Вывод в лоб
Console.Write("Квадрат от ");
Console.Write(number);
Console.Write(" равен ");
Console.WriteLine(sum);

// Вывод через $
Console.WriteLine($"Квадрат от {number} равен {sum}");

// вывод с обращением к переменной
Console.WriteLine("Квадрат от {0} равен {1}", number, sum);

// Использованеи библиотеки Math
int sum1 = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine("Квадрат от {0} равен {1}", number, sum1);

// Вывод через +
Console.WriteLine("Квадрат от " + number + " равен " + sum1);
