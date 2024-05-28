using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON___lv7
{
    public class Book : IItem
    {
        public string Title { get; private set; }
        public double Price { get; private set; }

        public Book(string title, double price)
        {
            this.Title = title;
            this.Price = price;
        }

        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }

        public override string ToString()
        {
            return "Book: " + this.Title + Environment.NewLine + " -> Price: " + this.Price;
        }

    }
}
