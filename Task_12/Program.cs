// Напишите программу, котрая будет принимать на вход 2 числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления


Console.WriteLine("Введите 2 числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 % num2 == 0)
{
    Console.WriteLine(num1 + ", " + num2 + " -> Кратно");
}
else
{
    Console.WriteLine(num1 + ", " + num2 + " -> Не кратно, остаток " + num1 % num2);
}