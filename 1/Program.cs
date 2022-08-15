// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Boolean IsPalindrom(int targetNumber)
{
    string numberString = Convert.ToString(targetNumber);

    for (int i = 0; i < numberString.Length / 2; i++)
    {
        if (numberString[i] != numberString[numberString.Length - i - 1])
        {
            return false;
        }
    }

    return true;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (IsPalindrom(number)) Console.WriteLine("Число является палиндромом");
else Console.WriteLine("Число не является палиндромом");

