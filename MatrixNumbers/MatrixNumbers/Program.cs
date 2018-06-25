using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MatrixNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = Enum.GetNames(typeof(ConsoleColor));
            int next;
            Random random = new Random();
            Console.BackgroundColor = ConsoleColor.Black;
            
            while (true)
            {
                next = random.Next(0, colors.Length);
                Console.ForegroundColor = (ConsoleColor) next;
                Console.Write(random.Next(0,100));
                Thread.Sleep(10);
            }
        }
    }
}
