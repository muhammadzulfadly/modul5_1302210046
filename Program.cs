using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302210046
{
    internal class Program
    {
        public class Penjumlahan
        {
            public T JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
            {
                dynamic input1 = angka1;
                dynamic input2 = angka2;
                dynamic input3 = angka3;

                return input1 + input2 + input3;
            }
        }

        static void Main(string[] args)
        {
            Penjumlahan tambah = new Penjumlahan();
            Console.WriteLine(tambah.JumlahTigaAngka(13, 02, 21));
        }
    }
}
