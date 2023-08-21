using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseTernaryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time > 6 && time < 18)
            {
                Console.WriteLine("Day");
            }
            else
            {
                Console.WriteLine("Night");
            }

            string result = time > 18 ? "Dark" : "Bright";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
