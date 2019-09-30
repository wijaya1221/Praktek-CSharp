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
            string nim, nama;
            int teoriTgs, teoriUTS, teoriUAS, prakTgs, prakUTS, prakUAS;
            float hslTeori, hslPrak, hslAkhir;
            Console.Write("NIM = ");
            nim = Console.ReadLine();
            Console.Write("Nama = ");
            nama = Console.ReadLine();
            Console.WriteLine("\nNilai Teori : ");
            Console.Write("\tTugas = ");
            teoriTgs = Convert.ToInt32(Console.ReadLine());
            Console.Write("\tUTS   = ");
            teoriUTS = Convert.ToInt32(Console.ReadLine());
            Console.Write("\tUAS   = ");
            teoriUAS = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nNilai Praktek : ");
            Console.Write("\tTugas = ");
            prakTgs = Convert.ToInt32(Console.ReadLine());
            Console.Write("\tUTS   = ");
            prakUTS = Convert.ToInt32(Console.ReadLine());
            Console.Write("\tUAS   = ");
            prakUAS = Convert.ToInt32(Console.ReadLine());
            hslTeori = (float)0.2 * teoriTgs + (float)0.3 * teoriUTS + (float)0.5 * teoriUAS;
            hslPrak = 0.2f * prakTgs + 0.3f * prakUTS + 0.5f * prakUAS;
            hslAkhir = 0.4f * hslPrak + 0.6f * hslTeori;
            Console.WriteLine("\nHasil AKhir : ");
            Console.WriteLine("\tTeori                      = {0}", hslTeori);
            Console.WriteLine("\tPraktek                    = {0}", hslPrak);
            Console.WriteLine("\tNilai Akhir Keseluruhan    = {0}", hslAkhir);
            Console.ReadKey();


        }
    }
}
