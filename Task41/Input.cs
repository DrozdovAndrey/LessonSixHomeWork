// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3



namespace HomeWork6   //MethodsInput
{
    class Input  
    {
        public static void InputNumbersToArray(double[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Число {i + 1}:");
                array[i] = CheckInputNumbers();
            }

        }

        public static int CheckInputCountNumbers()
        {
            try
            {
                Console.WriteLine("Сколько чисел вы хотите ввести (введите натуральное число больше 0):");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number < 0) number = number * -1;
                if (number == 0)
                {
                    Console.WriteLine("Вы ввели неправильные данные");
                    return CheckInputCountNumbers();
                }
                return number;
            }
            catch
            {
                Console.WriteLine("Вы ввели неправильные данные");
                return CheckInputCountNumbers();
            }

        }

        public static double CheckInputNumbers()
        {
            try
            {
                double number = Convert.ToDouble(Console.ReadLine());
                return number;
            }
            catch
            {
                Console.WriteLine("Вы ввели неправильные данные, повторите ввод последнего числа");
                return CheckInputNumbers();
            }

        }
    }
}