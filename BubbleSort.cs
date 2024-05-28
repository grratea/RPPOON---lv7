using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON___lv7
{
    public class BubbleSort : SortStrategy
    {
        public override void Sort(double[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        this.Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }
    }
}
