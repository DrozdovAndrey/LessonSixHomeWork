// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
using Input;


namespace HomeWork6
{
    class Task43
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Эта программа находит точку пересечения двух прямых,");
            Console.WriteLine("заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
            Console.WriteLine("Пожалуйста, введите значения переменных к и b");
            Console.WriteLine("Введите значение к1:");
            double k1 = InputChek.CheckInputNumbers();
            Console.WriteLine("Введите значение к2:");
            double k2 = InputChek.CheckInputNumbers();
            Console.WriteLine("Введите значение b1:");
            double b1 = InputChek.CheckInputNumbers();
            Console.WriteLine("Введите значение b2:");
            double b2 = InputChek.CheckInputNumbers();
            double x = Math.Round((b2 - b1) / (k1 - k2), 2);
            double y = Math.Round(k1 * x + b1, 2);
            Console.WriteLine($"Точка пересечения этих линий - это точка с координатами по оси x = {x} и по оси y = {y}");
        }
    }
}