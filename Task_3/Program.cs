// Напишите задачу, которая будет выдавать название дня недели по заданному номеру
//  3 -> Среда
//  5 -> Пятница

Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number==1)
Console.Write("Это Понедельник");
else if (number==2)
Console.Write("Это Вторник");
else if (number==3)
Console.Write("Это Среда");
else if (number==4)
Console.Write("Это Четверг");
else if (number==5)
Console.Write("Это Пятница");
else if (number==6)
Console.Write("Это Суббота");
else if (number==7)
Console.Write("Это Воскресенье");
else
Console.Write("Введите число от 1 до 7");