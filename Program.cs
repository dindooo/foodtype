using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foodType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foodType foodtype1 = new foodType();

            foodtype1.setName("Banana");
            foodtype1.setProtein(4);
            foodtype1.setCarbs(93);
            foodtype1.setFat(3);

            Console.WriteLine(foodtype1.ToString());

            foodType foodtype2 = new foodType("Jagoda", 2, 67, 4);

            Console.WriteLine(foodtype2.ToString());

            Console.ReadKey();
        }
    }
}
