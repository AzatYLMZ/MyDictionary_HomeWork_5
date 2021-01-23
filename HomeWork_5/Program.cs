using MyDictionary;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> ogrenciler = new MyDictionary<string, int>();

            ogrenciler.Add("Azat", 15);
            ogrenciler.Add("Berat", 16);
            ogrenciler.Add("Rojda", 25);


            ogrenciler.Yazdir();
        }
    }
}