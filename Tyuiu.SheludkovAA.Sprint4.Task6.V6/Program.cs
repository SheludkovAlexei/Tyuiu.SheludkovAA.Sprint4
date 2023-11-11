using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SheludkovAA.Sprint4.Task6.V6.Lib;

namespace Tyuiu.SheludkovAA.Sprint4.Task6.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

           
            Console.Title = "Спринт #3 | Выполнил: Шелудков А. А. | АСОиУб-23-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Шелудков А. А. | АСОиУб-23-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string[] mmm = { "Борис", "Анна", "Михаил", "Ирина", "Сергей", "Татьяна", "Олег" };
            Console.WriteLine("Исходный массив : ");
            Console.WriteLine();
            for (int i = 0; i < mmm.Length; i++)
            {
                Console.Write(mmm[i]+" ");
            }

            Console.WriteLine();
            Console.WriteLine();

            string[] mm1 = ds.Calculate(mmm);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Элементы массива, в которых 5 символов : ");
            Console.WriteLine();
            for (int i = 0; i < mm1.Length; i++)
            {
                Console.Write(mm1[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
