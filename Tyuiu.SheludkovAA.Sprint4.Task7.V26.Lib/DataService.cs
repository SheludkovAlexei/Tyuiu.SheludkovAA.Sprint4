using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SheludkovAA.Sprint4.Task7.V26.Lib
{
    public class DataService : ISprint4Task7V26
    {
        public int Calculate(int n, int m, string value)
        {
            int index = 0;
            int pr = 1;
            int[,] mtr = new int[n, m];
            for (int i = 0; i<n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mtr[i, j] = int.Parse(value.Substring(index, 1));
                    index++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mtr[i, j] % 2 == 0)
                    {
                        pr *= mtr[i, j];
                    }
                }
            }
            return pr;
        }
    }
}
