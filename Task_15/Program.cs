﻿Console.Write("Введите день недели");
int number = int.Parse(Console.ReadLine());
if (number >= 1 && number <= 5)
{
    Console.Write("Нет");
}
else if (number >= 6 && number <= 7)
{
    Console.Write("Да");
}