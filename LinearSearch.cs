using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON___lv7
{
    public class LinearSearch : ISearchStrategy
    {
        public bool Search(double[] array, double number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    return true; 
                }
            }
            return false; 
            // nez jel moramo vratiti i index
        }
    }
}
