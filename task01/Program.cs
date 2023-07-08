// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int FindThirdDigit(int number3) //находим третью цифру числа (сперва отрезаем у числа все, кроме 3х первых символов, затем находим последний символ числа)
{
    int razryad = FindRazryad(number3);
    number3 = number3 / (razryad / 100);
    number3 = number3 % 10;
    return number3;
}

int FindRazryad(int findRazryad) //находим разрядную единицу
{
    int razryadNumber = 1;
    while (findRazryad > 9)
    {
        findRazryad = findRazryad / 10;
        razryadNumber = razryadNumber * 10;
    }
    return razryadNumber;
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

if (FindRazryad(number) < 100)
    Console.WriteLine("В числе менее 3х знаков, пожалуйста, введите 3х значное или более число");
else
    Console.WriteLine(FindThirdDigit(number));
