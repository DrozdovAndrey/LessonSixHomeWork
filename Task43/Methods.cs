
namespace Input
{
    class InputChek
    {


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
        public static double CheckInputK2(double k1, double k2)
        {

            if (k1 != k2)
            {
                return k2;
            }
            else
            {
                Console.WriteLine("Введено некорректное значение, введите k2");
                return CheckInputNumbers();
            }

        }

    }
}