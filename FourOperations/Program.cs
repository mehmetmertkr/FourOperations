using System;

namespace FourOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int loop;
            for (loop = 1; loop < 99; loop++)
            {
                double operation, number1, number2, result;
                Console.WriteLine(" (1) Toplama işlemi \n (2) Çıkarma işlemi \n (3) Çarpma işlemi \n (4) Bölme işlemi \n ");
                operation = Convert.ToInt32(Console.ReadLine());
                Console.Write("1.Sayıyı giriniz:   ");
                number1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2.Sayıyı giriniz:   ");
                number2 = Convert.ToInt32(Console.ReadLine());
                //first project
                //mehmetmertkr
                switch (operation)
                {
                    case 1:
                        result = number1 + number2; Console.Write("Toplama işlemi Sonucu = {0}\n", result); break;
                        Console.WriteLine("Tekrar işlem yapmak için entere basın"); Console.ReadKey();
                    case 2:
                        result = number1 - number2; Console.Write("Çıkarma işlemi Sonucu = {0}\n", result); break;
                        Console.WriteLine("Tekrar işlem yapmak için entere basın"); Console.ReadKey();
                    case 3:
                        result = number1 * number2; Console.Write("Çarpma işlemi Sonucu = {0}\n", result); break;
                        Console.WriteLine("Tekrar işlem yapmak için entere basın"); Console.ReadKey();
                    case 4:
                        result = number1 / number2; Console.Write("Bölme işlemi Sonucu = {0}\n", result); break;
                        Console.WriteLine("Tekrar işlem yapmak için entere basın"); Console.ReadKey();
                    default: Console.WriteLine("Hatalı seçim yapyınız"); break;
                }
            }Console.ReadKey();    
        }
    }
}