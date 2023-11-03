using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SheludkovAA.Sprint4.Task2.V25.Lib;

namespace Tyuiu.SheludkovAA.Sprint4.Task2.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #3 | Выполнил: Шелудков А. А. | АСОиУб-23-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Шелудков А. А. | АСОиУб-23-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите размер массива : ");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[len];
            Console.WriteLine("Введите элементы массива : ");
            Random rnd = new Random();
            for (int i = 0; i < len; i++)
            {
                arr[i] = rnd.Next(3, 9);
            }
            Console.WriteLine("Массив : ");
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(arr[i] +"\t");
            }

            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Произведение всех нечетных элементов массива равно : " + ds.Calculate(arr));
            Console.ReadKey();
        }
    }
}
