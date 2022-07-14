
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
    }
}