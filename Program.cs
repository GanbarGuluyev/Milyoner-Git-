using System.Drawing;
using System;

namespace Milyoner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                //  Kim Milyoner Olmak İster

            Console.WriteLine(" Kim Milyoner Olmak İster \n ");
            Console.Write(" İsim Giriniz: ");
            string isim = Console.ReadLine();
            Console.Write(" Soyisim Girin: ");
            string soyisim = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(" Hoş Geldin: " + isim + " " + soyisim);


        }
    }
}