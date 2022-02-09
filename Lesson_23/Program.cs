using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_23
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintAsync();
            Console.ReadKey();
        }
        static int Faktorial(object z)
        {
            int n = (int)z;
            int[] numArray = new int[n];
            numArray[0] = 1;
            int num = 1;
            for (int i = 0; i < n; i++)
            {
                if (i>0)
                {
                    numArray[i]= numArray[i-1]+1;
                    num = num * numArray[i];
                }
            }
            return num;
        }
        static async Task PrintAsync()
        {
            Console.Write("Введите любое целое число: ");
            int z = Convert.ToInt32(Console.ReadLine());
            int result = await Task.Run(() => Faktorial(z));
            Console.WriteLine($"Факториал данного числа = {result}"); ;
        }
    }
}
