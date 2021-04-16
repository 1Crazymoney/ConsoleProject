using System;

namespace ConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            while (0 == 0)
            {

                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;

                int a;

                Console.Write("Toplama işlemi |1|\nÇıkarma işlemi |2|\nÇarpma  işlemi |3|\nBölme   işlemi |4|\n\nYapmak istediğiniz işlem türünün numarasını yazınız :");

                a = Convert.ToInt32(Console.ReadLine());

                if (a == 1)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Toplama işlemine başarıyla geçildi.");
                    Console.WriteLine("------------------------------------");
                    int b, c;

                    Console.Write("1. Sayıyı giriniz: ");

                    b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("----------------");

                    Console.Write("2. Sayıyı giriniz: ");

                    c = Convert.ToInt32(Console.ReadLine());

                    int m = b + c;
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("İşlemininiz sonucu: " + m);
                    Console.WriteLine("------------------------------------");

                }
                else if (a == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Çıkarma işlemine başarıyla geçildi.");
                    Console.WriteLine("------------------------------------");

                    int b, c;

                    Console.Write("1. Sayıyı giriniz: ");

                    b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("----------------");

                    Console.Write("2. Sayıyı giriniz: ");

                    c = Convert.ToInt32(Console.ReadLine());

                    int m = b - c;

                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("İşlemininiz sonucu: " + m);
                    Console.WriteLine("------------------------------------");

                }
                else if (a == 3)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Çarpma işlemine başarıyla geçildi.");
                    Console.WriteLine("------------------------------------");

                    int b, c;

                    Console.Write("1. Sayıyı giriniz: ");

                    b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("-------------------");


                    Console.Write("2. Sayıyı giriniz: ");

                    c = Convert.ToInt32(Console.ReadLine());

                    int m = b * c;
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("İşleminizin sonucu: " + m);
                    Console.WriteLine("------------------------------------");
                }
                else if (a == 4)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Bölme işlemine başarıyla geçildi.");
                    Console.WriteLine("------------------------------------");

                    double b, c;

                    Console.Write("1. Sayıyı giriniz: ");

                    b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("-------------------");

                    Console.Write("2. Sayıyı giriniz: ");

                    c = Convert.ToInt32(Console.ReadLine());

                    double m = b / c;

                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("İşleminizin sonucu: " + m);
                    Console.WriteLine("------------------------------------");


                }
                else if (a <= 0 || a >= 5)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("------------------------------------");

                    Console.WriteLine("Geçersiz bir sayı girdiniz!");

                    Console.WriteLine("------------------------------------");

                }
                string bitir;

                Console.Write("Çıkmak için Ç işlem yapmaya devam etmek için D yazınız: ");

                bitir = Convert.ToString(Console.ReadLine());

                if (bitir == "Ç" || bitir == "ç")
                {
                    break;
                }

            }
        }
    }
}
