using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SheludkovAA.Sprint4.Task4.V14.Lib;

namespace Tyuiu.SheludkovAA.Sprint4.Task4.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
   

            Console.Title = "Спринт #3 | Выполнил: Шелудков А. А. | АСОиУб-23-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Шелудков А. А. | АСОиУб-23-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество строчек в массиве : ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Количество колонок в массиве : ");
            int coll = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Количество колонок и строчек в массиве : ");
            Console.WriteLine(rows + " | " + coll);
            int[,] mtr = new int[rows, coll];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coll; j++)
                {
                    Console.WriteLine($"Введите {i},{j} элемент массива");
                    mtr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nМассив : ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coll; j++)
                {
                    Console.WriteLine($"{mtr[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Измененная матрица : ");
            int[,] mtr1 = ds.Calculate(mtr);
            Console.WriteLine("\nМассив : ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coll; j++)
                {
                    Console.WriteLine($"{mtr1[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
