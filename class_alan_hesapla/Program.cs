using System;

namespace class_alan_hesapla
{
    class Program
    {
        static void Main(string[] args)
        {
            while (0 == 0)
            {

                Console.WriteLine("Alan Hesaplamak için = 1'e Çevre Hesaplamak İçin 2'ye Program'ı kapatmak için 3'e basın...");
                int sec = Convert.ToInt32(Console.ReadLine());

                Dikdortgen dikdortgen = new Dikdortgen();

                if (sec == 1)
                {
                    Console.WriteLine("Yüksekliği ve uzunluğu giriniz:");
                    dikdortgen.b = Convert.ToInt32(Console.ReadLine());
                    dikdortgen.h = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Dikdortgen Alanı => " + alanhesapla(dikdortgen.b, dikdortgen.h));

                }

                else if (sec == 2)
                {
                    Console.WriteLine("Yüksekliği ve uzunluğu giriniz");
                    dikdortgen.b = Convert.ToInt32(Console.ReadLine());
                    dikdortgen.h = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Dikdörtgenin Çevresi => " + cevrehesapla(dikdortgen.b, dikdortgen.h));
                }

                else if (sec == 3)
                {
                    break;
                }

                static int alanhesapla(int b, int h)
                {
                    return b * h;
                }

                static int cevrehesapla(int b, int h)
                {
                    int c = 2 * b * 2 * h;
                    return c;
                }
            }
        }
    }

    class Dikdortgen
    {
        public int b { get; set; }

        public int h { get; set; }


    }
}
