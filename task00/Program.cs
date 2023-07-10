// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
using System.Reflection.Metadata.Ecma335;


int FindSecondDigit(int number2) //находим вторую цифру числа
{
    number2 = number2 / 10;
    number2 = number2 % 10;
    return number2;
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

if (FindRazryad(number) != 3) //определяем является ли число трехзначным
    Console.WriteLine("Пожалуйста, введите трехзначное число");
else //если число является трехзначным, то выводим ответ
{
        Console.WriteLine("Ответ: " + FindSecondDigit(number));
}
