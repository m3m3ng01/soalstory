using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soalstory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nama Restoran Anda: ");
            string nama = Console.ReadLine();
            //Console.Write("Tanggal: ");
            //DateTime Tanggal = Console.ReadLine();
            Console.Write("Nama kasir : ");
            string kasir = Console.ReadLine();

           
                Console.Write("masukkan menu: ");
                string menu = Console.ReadLine();

            Console.Write("Harga: ");
                int harga =int.Parse(Console.ReadLine());
            
            Console.WriteLine(nama);
            Console.WriteLine( DateTime.MaxValue);
            Console.WriteLine("Nama Kasir :" + kasir);
            Console.WriteLine("------------------------------------");

            Console.Write(menu + " " + harga );
            Console.ReadLine();
        }
    }
}
