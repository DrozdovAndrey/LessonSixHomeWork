namespace HomeWork6 //OtherMethods
{
    class Methods
    {
        public static void PrintArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }

        public static int CountNumbersGreaterThenZero(double[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0) count++;
            }
            return count;
        }
    }
}