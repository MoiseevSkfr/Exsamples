// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да 
//a = 2, b = 10 -> нет 
//a = 9, b = -3 -> да 
//a = -3 b = 9 -> нет

Console.WriteLine("Введите два числа");
int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());
    if ((numberB*numberB) == numberA){
    Console.WriteLine(numberA +" Является квадратом " + numberB);
    }
    else {
    Console.WriteLine(numberA +" Не является квадратом " + numberB);
    }