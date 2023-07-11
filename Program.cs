/*
using System;

class Program
{
        static void Main()
    {
        Console.WriteLine("Введите трехзначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int secondDigit = GetSecondDigit(number);

        Console.WriteLine("Вторая цифра введенного числа: " + secondDigit);
    }

    static int GetSecondDigit(int number)
    {
        // Получаем вторую цифру числа с помощью деления на 10 и взятия остатка от деления на 10
        int secondDigit = (number / 10) % 10;

        return secondDigit;
    }
}
*/
/*
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int thirdDigit = GetThirdDigit(number);

        if (thirdDigit != -1)
        {
            Console.WriteLine("Третья цифра числа: " + thirdDigit);
        }
        else
        {
            Console.WriteLine("Третьей цифры нет в числе.");
        }
    }

    static int GetThirdDigit(int number)
    {
        // Если число трехзначное, получаем третью цифру с помощью деления на 100 и взятия остатка от деления на 10
        if (number >= 100 && number <= 999)
        {
            int thirdDigit = (number / 100) % 10;
            return thirdDigit;
        }
        else
        {
            return -1; // Возвращаем -1, если число не является трехзначным
        }
    }
}
*/
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите цифру, обозначающую день недели (1 - понедельник, 2 - вторник и т.д.):");
        int dayOfWeek = Convert.ToInt32(Console.ReadLine());

        bool isWeekend = CheckIfWeekend(dayOfWeek);

        if (isWeekend)
        {
            Console.WriteLine("День недели является выходным.");
        }
        else
        {
            Console.WriteLine("День недели не является выходным.");
        }
    }

    static bool CheckIfWeekend(int dayOfWeek)
    {
        // Проверяем, является ли день выходным, где 6 и 7 обозначают субботу и воскресенье соответственно
        if (dayOfWeek == 6 || dayOfWeek == 7)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
