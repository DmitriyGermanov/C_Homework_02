// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели ");
int dayOfTheWeek = int.Parse(Console.ReadLine()!);

string[] array = //вводим массив названий дней недели
{
    "Понедельник",
    "Вторник",
    "Среда",
    "Четверг",
    "Пятница",
    "Суббота",
    "Воскресенье"
}; 

if (dayOfTheWeek > 7 || dayOfTheWeek < 1) //проверяем, что число является днем недели
    Console.WriteLine("Ошибка: Введите номер дня недели (от 1 до 7)");
else
    Console.WriteLine(DayOf(dayOfTheWeek));

string DayOf(int day) //находим нужный индекс в массиве и возвращаем значения массива
{
    string outputDay = array[day - 1];
    return outputDay;
}
