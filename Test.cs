using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON___lv7
{
    public class Test
    {
        public static void Run1()
        {
            BubbleSort bubbleSort = new BubbleSort();
            double[] numbers = new double[]{ 7.0, 8.0, 9.0, 4.0, 5.0, 6.0, 3.0, 2.0, 1.0 };
            NumberSequence seq = new NumberSequence(numbers);

            seq.SetSortStrategy(bubbleSort);
            seq.Sort();

            Console.WriteLine(seq.ToString());
        }

        public static void Run2()
        {
            LinearSearch linearSearch = new LinearSearch();
            double[] numbers = new double[] { 7.0, 8.0, 9.0, 4.0, 5.0, 6.0, 3.0, 2.0, 1.0 };
            NumberSequence seq = new NumberSequence(numbers);

            seq.SetSearchStrategy(linearSearch);

            int number1 = 3;
            Console.WriteLine($"Number {number1} is in array: " + seq.Search(number1));

            int number2 = 10;
            Console.WriteLine($"Number {number2} is in array: " + seq.Search(number2));
        }

        public static void Run3()
        {

            SystemDataProvider provider = new SystemDataProvider();
            FileLogger fileLogger = new FileLogger("C:\\Users\\Tea\\Desktop\\faks\\Razvoj Programske Podrške Objektno Orijentiranim Načelima\\LV\\LV 1\\RPPOON - lv7\\log.txt");
            ConsoleLogger consoleLogger = new ConsoleLogger();

            provider.Attach(fileLogger);
            provider.Attach(consoleLogger);

            while (true)
            {
                provider.GetCPULoad();
                provider.GetAvailableRAM();

                System.Threading.Thread.Sleep(1000); 
            }
        }

        public static void Run4()
        {
            /*if (currentLoad > this.previousCPULoad * 1.1 || currentLoad < this.previousCPULoad * 0.9)
            {
                this.Notify();
            }*/

            // IDE U SYSTEM...
            // isti test
        }

        public static void Run5and6()
        {
            IVisitor visitor = new BuyVisitor();
            Book book = new Book("LOTR", 19.99);
            DVD dvd = new DVD("Arthur u zemlji Minimoya", DVDType.MOVIE, 5.99);
            VHS vhs = new VHS("glazba", 3.49);

            Console.WriteLine(book.ToString());
            Console.WriteLine("Buy price for book: " + visitor.Visit(book));

            Console.WriteLine();

            Console.WriteLine(dvd.ToString());
            Console.WriteLine("Buy price for dvd: " + visitor.Visit(dvd));

            Console.WriteLine();

            Console.WriteLine(vhs.ToString());
            Console.WriteLine("Buy price for vhs: " + visitor.Visit(vhs));


            /*****************************************************************/

            Console.WriteLine("\nZADATAK 6:\n");

            visitor = new RentVisitor();

            Console.WriteLine("Rent price for book: " + visitor.Visit(book));

            Console.WriteLine();

            Console.WriteLine("Rent price for dvd: " + visitor.Visit(dvd));

            Console.WriteLine();

            Console.WriteLine("Rent price for vhs: " + visitor.Visit(vhs));

            Console.WriteLine();

            DVD dvd2 = new DVD("pokus", DVDType.SOFTWARE, 10);
            Console.WriteLine("Rent price for dvd2: " + visitor.Visit(dvd2));
        }

        public static void Run7()
        {
            Cart cart = new Cart();
            Book book = new Book("LOTR", 19.99);
            DVD dvd = new DVD("Arthur u zemlji Minimoya", DVDType.MOVIE, 5.99);
            VHS vhs = new VHS("glazba", 3.49);

            cart.AddItem(book);
            cart.AddItem(dvd);
            cart.AddItem(vhs);

            IVisitor visitor = new RentVisitor();

            Console.WriteLine("Sum of the cart is: " + cart.Accept(visitor));

            DVD dvd2 = new DVD("pokus", DVDType.SOFTWARE, 10);

            cart.RemoveItem(dvd);
            cart.AddItem(dvd2);

            Console.WriteLine();

            Console.WriteLine("Sum of the cart is: " + cart.Accept(visitor));
        }

    }
}
