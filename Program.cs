using System;
using System.Linq;

namespace _15
{
    class Program
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 2, 4, 5, 4, 6, 7, 6 };
            PrintArray(array);

            bool flag;
            do
            {
                flag = false;
                for (int i = 0; i < array.Length; i++)
                {
                    int count = array.Count(x => x == array[i]);//понравилось очень сильно
                    if (count > 1)
                    {
                        array[i] *= i;
                        flag = true;
                        PrintArray(array);
                    }
                }
            } while (flag);


            Console.ReadLine();
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();

        }
    }
}