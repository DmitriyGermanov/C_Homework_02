// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
using System.Reflection.Metadata.Ecma335;

int FindFirstDigit(int number1) //находим первую цифру числа
{
    return number1 / 100;
}
int FindSecondDigit(int number2) //находим вторую цифру числа
{
    number2 = number2 / 10;
    return number2 % 10;
}
int FindThirdDigit(int number3) //находим третью цифру числа
{
    number3 = number3 % 100;
    number3 = number3 % 10;
    return number3;
}
int FindRazryad(int findRazryad) //находим разрядность числа
{
    int razryadNumber = 0;
    while (findRazryad > 0)
    {
        findRazryad = findRazryad / 10;
        razryadNumber++;
    }
    return razryadNumber;
}

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);

int digit1 = FindFirstDigit(number);
int digit2 = FindSecondDigit(number);
int digit3 = FindThirdDigit(number);

if (FindRazryad(number) != 3) //определяем является ли число трехзначным
    Console.WriteLine("Пожалуйста, введите трехзначное число");
else //если число является трехзначным, то выводим ответ
{
    Console.WriteLine(FindRazryad(number));
    Console.WriteLine("Ответ: " + ((digit1 * 10) + digit3));
}
