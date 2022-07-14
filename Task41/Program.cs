using MethodsInput;
using OtherMethods;



namespace HomeWork6
{
    class Task41
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите несколько чисел и программа посчитает сколько из них больше нуля.");
            int n = Input.CheckInputCountNumbers();
            double[] numbers = new double[n];
            Input.InputNumbersToArray(numbers);
            Methods.PrintArray(numbers);
            Console.WriteLine();
            Console.WriteLine($"Колличество чисел больше нуля: {Methods.CountNumbersGreaterThenZero(numbers)}");
        }
    }
}