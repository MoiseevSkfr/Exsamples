//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

//456 -> 46
//782 -> 72
//918 -> 98

//Console.WriteLine("Рандомное число:" + num);
//int firstNumber = num / 100;
//int thirdNumber = num % 10;

int FindFirstDigit(int number)
{
    int firstNumber = number / 100;
    return firstNumber;
}

int FindThirdDigit(int number)
{
    int thirdNumber = number % 10;
    return thirdNumber;
}

void RemoveTheMiddle(int number,int firstNumber,int thirdNumber)
{
    
    
    Console.WriteLine("Рандомное число:" + number);
    Console.WriteLine(firstNumber.ToString() + thirdNumber.ToString());
}

int num = new Random().Next(100,1000);
int firstDigit = FindFirstDigit(num);
int thirdDigit = FindThirdDigit(num);
RemoveTheMiddle(num,firstDigit,thirdDigit);

int num1 = new Random().Next(500,1000);
int firstDigit1 = FindFirstDigit(num1);
int thirdDigit1 = FindThirdDigit(num1);
RemoveTheMiddle(num1,firstDigit1,thirdDigit1);

int num2 = new Random().Next(950,999);
int firstDigit2 = FindFirstDigit(num2);
int thirdDigit2 = FindThirdDigit(num2);
RemoveTheMiddle(num2,firstDigit2,thirdDigit2);



