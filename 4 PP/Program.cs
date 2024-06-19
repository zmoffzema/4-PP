using System;
using System.Threading;

class Countdown
{
    static void Main()
    {
        Console.WriteLine("Обратный отсчет");

        // Запрашиваем количество секунд у пользователя
        Console.Write("Введите количество секунд: ");
        int seconds;
        if (int.TryParse(Console.ReadLine(), out seconds) && seconds > 0)
        {
            // Выполняем обратный отсчет
            for (int i = seconds; i >= 0; i--)
            {
                Console.Clear();
                Console.WriteLine($"Осталось {i} секунд(ы)");
                Thread.Sleep(1000); // Задержка на 1 секунду
            }

            Console.WriteLine("Обратный отсчет завершен!");
        }
        else
        {
            Console.WriteLine("Пожалуйста, введите корректное количество секунд.");
        }
    }
}
