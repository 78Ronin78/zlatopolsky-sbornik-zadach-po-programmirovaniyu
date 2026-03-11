/*
  Глава 1. Простейшие программы. Арифметические выражения.

  Задача 1.3. Составить программу вывода на экран числа, вводимого с клавиатуры.
  Выводимому числу должно предшествовать сообщение "Вы ввели число".

*/

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            var digit = Console.ReadLine();
            if (int.TryParse(digit, out int d))
            {
                Console.WriteLine("Вы ввели целое число: {0}", digit);
            } else
            {
                Console.WriteLine("Вы ввели не целое число");
            }
           
        }
    }
}
