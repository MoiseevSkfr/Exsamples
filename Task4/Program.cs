//Программа которая выводит случайное число из отрезка [10,99]
// и показывает наибольшую цифру числа.

//Например:
//78->8
//12->2
//85-8

void FindLargestDigit(int num)
{
    int firstNumber = num / 10; // деление на цело 78 = 7
    int secondNumber = num % 10; // вычислние последней цыфры 78 = 8
    Console.WriteLine("Рандомное число:" + num);
    Console.WriteLine(firstNumber);
    Console.WriteLine(secondNumber);

    if (firstNumber > secondNumber)
    {
        Console.WriteLine("Первая цифра больше второй");
    }
    else if (secondNumber > firstNumber)
    {
        Console.WriteLine("Вторая цифра больше первой");
    }
    else
    {
        Console.WriteLine("Цифры равны");
    }
}
int number = new Random().Next(10, 100);
FindLargestDigit(number);