using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON___lv7
{
    public class Cart : IItem
    {
        private List<IItem> items;

        public Cart()
        {
            items = new List<IItem>();
        }

        public void AddItem(IItem item)
        {
            items.Add(item);
        }

        public void RemoveItem(IItem item)
        {
            items.Remove(item);
        }

        public double Accept(IVisitor visitor)
        {
            double sum = 0;
            foreach (IItem item in items)
            {
                sum += item.Accept(visitor);
            }
            return sum;
        }

    }
}
