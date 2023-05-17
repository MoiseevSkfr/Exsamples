// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя).
// Например:
//4 -> 16 
//-3 -> 9 
//-7 -> 49

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(number * number);
Console.WriteLine("квадрат числа равен = " + number * number);
