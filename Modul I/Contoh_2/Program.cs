using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoh_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string pesan;
            Console.Title = "Judul Jendela Console";
            Console.WriteLine("Status Numberr Lock = {0}", Console.NumberLock);
            Console.WriteLine("Status Capss Lock = {0}", Console.CapsLock);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Input sembarang kata = ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Magenta;
            pesan = Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine("\nAnda menginput kata : ");
            Console.CursorVisible = false;
            Console.SetCursorPosition(10, 10);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\"{0}\"", pesan);
            Console.ReadKey();
        }
    }
}
