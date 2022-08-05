Console.WriteLine("Hello, Marina!");

// Семинар 1
// Задача 1

// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя)

// Console.Clear();

// Console.Write("Введите число: ");

// int number = Convert.ToInt32(Console.ReadLine());
// int sqrt = number * number;
// // number *= number;
// // int sqrt1 = Convert.ToInt32(Math.Pow(number, 2));

// Console.Write("Число в квадрате: " + sqrt);

// Задача 2


// Написать программу, которая принимает на вход 2 числа и проверяет является ли первое число квадратом второго числа

// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int sqrt = num2 * num2;
// if (num1 == sqrt)
//     Console.Write("Первое число - квадрат второго числа");
// else
//     Console.Write("Первое число - не квадрат второго числа");


// Задача 3

// Напишите программу, которая будет выдавать название дня недели по заданному номеру

Console.Write("введите номер дня: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day < 1 || day > 7)
{
    Console.Write("Некорректное значение");
}

else
{
    if (day == 1)
    {
        Console.Write("Понедельник");
    }
    if (day == 2)
    {
        Console.Write("Вторник");
    }
    if (day == 3)
    {
       Console.Write("Среда");
    }
    if (day == 4)
    {
       Console.Write("Четверг");
    }
    if (day == 5)
    {
       Console.Write("Пятница");
    }
    if (day == 6)
    {
       Console.Write("Суббота");
    }
    if (day == 7)
    {
       Console.Write("Воскресенье");
    }
}
