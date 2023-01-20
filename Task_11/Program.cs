// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа


int num = new Random().Next(100,1000);
int num1, num2, num3;

Console.WriteLine(num);

num3 = num % 10;
num /= 10;
num2 = num % 10;
num /= 10;
num1 = num % 10;
num /= 10;


Console.Write(num1 + "" + num3);

