using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoh_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nim, nama, waktu;
            byte umur = 20;
            char kelas = 'A';
            float IPK = 3.25f;
            nim = "12.111.001";
            nama = "Susan";
            waktu = "Pagi";
            Console.Write("NIM = {0}\nNama = \"{1}\"\n", nim, nama);
            Console.WriteLine("\tBerumur {0} tahun", umur);
            Console.Write("\tMasuk ke kelas TI-{0} {1}\n", kelas, waktu);
            Console.WriteLine("\tDengan IPK = {0}", IPK);
            Console.ReadKey();
        }
    }
}
