using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON___lv7
{
    public class RentVisitor : IVisitor
    {
        private const double RentTax = 0.1;
        public double Visit(DVD DVDItem)
        {
            if (DVDItem.Type == DVDType.SOFTWARE)
            {
                // return double.NaN;
                return DVDItem.Price; // ZA SEDMI ZAD
            }
            else 
            { 
                return DVDItem.Price * RentTax; 
            }
        }

        public double Visit(VHS VHSItem)
        {
            return VHSItem.Price * RentTax;
        }

        public double Visit(Book BookItem)
        {
            return BookItem.Price * RentTax;
        }
    }
}
