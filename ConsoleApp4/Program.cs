using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Menu\n1-Dikdörtgen\n2-Ucgen\n3-Dongu\n4-Cıkıs");
            Console.WriteLine("Secim : ");
            byte choice = Convert.ToByte(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("1-Alan\n2-Cevre");
                    Console.WriteLine("Secim : ");
                    choice = Convert.ToByte(Console.ReadLine());
                    Console.WriteLine("x : ");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("y : ");
                    int y = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine($"Alan : {x * y}");
                            break;
                        case 2:
                            Console.WriteLine($"Çevre : {2 * (x + y)}");
                            break;
                        default:
                            Console.WriteLine("Yanlış seçim");
                            break;
                    }
                    //choice =  Menu2();
                    break;
                case 2:
                    Console.WriteLine("1-Alan\n2-Cevre");
                    Console.Write("Secim : ");
                    choice = Convert.ToByte(Console.ReadLine());
                    
                    switch (choice)
                    {
                        case 1:
                            Console.Write("yükseklik : ");
                            int h = int.Parse(Console.ReadLine());
                            Console.Write("taban : ");
                            int a = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Alan : {h * a / 2}");
                            break;
                        case 2:
                            Console.Write("a : ");
                            a = int.Parse(Console.ReadLine());
                            Console.Write("b : ");
                            int b = int.Parse(Console.ReadLine());
                            Console.Write("c : ");
                            int c = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Çevre : {a + b + c}");
                            break;
                        default:
                            Console.WriteLine("Yanlış seçim");
                            break;
                    }
                    break;
                case 3:
                    Console.Clear();
                    Main(null);
                    break;
                case 4:
                    Environment.Exit(0);//return
                    break;
                default:
                    break;
            }

            Console.Read();*/

            /*
            //girilen iki sayı arasındaki asal sayıları yaz?

            Console.WriteLine("Min : ");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Max : ");
            int max = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = min; i <= max; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i%j == 0)
                        count++;
                }
                if(count == 0)                     
                    Console.WriteLine(i);               
                count = 0;             
            }
            Console.ReadLine();


            */

            /*
            //girilen iki sayı arasındaki asal sayıları yaz?(- değerleri alır)

            Console.WriteLine("sayı1 : ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("sayı2 : ");
            int number2 = int.Parse(Console.ReadLine());
            int count = 0;

            int min = Math.Min(number1, number2);
            if (min < 0)
                min = 0;

            int max = Math.Max(number1, number2);
            if (max < 0)
                max = 0;

            for (int i = min; i <= max; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                        count++;
                }
                if (count == 0)
                {
                    if (i > 1)
                        Console.WriteLine(i);
                }


                count = 0;
            }

            Console.ReadLine();



            */

            //0-100 arasındaki tek sayılrın toplama ve adeti, çiftlerin toplamı ve adeti yazdırın.
            /*
            int tektoplam = 0, tekadet=0,cifttoplam=0,ciftadet=0;
            for (int i = 0; i <= 100; i++)
            {
                if (i %2 == 0)
                    {
                    ciftadet++;
                    cifttoplam +=i;
                }
                else
                {
                    tekadet++;
                    tektoplam +=i;
                }

            }
            Console.WriteLine($"çiftlerin Toplamı = {cifttoplam} adet = {ciftadet}");
            Console.WriteLine($"teklerin Toplamı ={tektoplam} adet = {tekadet}");
            Console.Read();

            */

            //girilen sayının pozitif çarpanlarını yazınız.

            /*
             int sayi = 0;
             Console.WriteLine("sayı giriniz");
             sayi = int.Parse(Console.ReadLine());

             for (int i = 1; i <=sayi ; i++)
             {
                 if (sayi % i== 0)
                 {
                     Console.WriteLine(i);
                 }
             }

             Console.ReadLine();


             */


            // 0-100 arasındaki mükemmel sayıları bulma

            /*
            int sum = 0, count=0;
            for (int i = 1; i < 1000; i++)
            {

                for (int  j = 1; j < i; j++) 
                {
                    if(i % j ==0)
                     sum += j;                 
                }
                if (sum == i)
                {
                    Console.WriteLine(i);
                }
            }
           
           
            Console.ReadLine();

            */

            // üçgen çizimi  * yazayan program

            /*
            Console.WriteLine("kenar : ");
            int kenar = int.Parse(Console.ReadLine());
            for (int i = 1; i <= kenar ; i++)

            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
            Console.ReadLine();

            */

            // ok çizimi

            /*
            Console.WriteLine("kenar : ");
            int kenar = int.Parse(Console.ReadLine());
            int ort = kenar / 2;
            if (kenar % 2 == 1)
            {
                for (int i = 0; i < ort; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                for (int i = 0; i < ort + 1; i++)
                {
                    for (int j = ort + 1; j > i; j--)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < ort; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                for (int i = 0; i < ort; i++)
                {
                    for (int j = ort; j > i; j--)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadLine();

            */


            //girilen sayı kaç basamaklı bul?

            /*
            Console.Write("sayı :");
            int sayi = int.Parse(Console.ReadLine());
            int count = 0;
            while(sayi>0)

            {
               sayi /= 10;
               count++;
            }
            do
            {
                sayi/=10;
                count++;
            } while(sayi>0);
            Console.WriteLine(count);

            Console.ReadLine();
            */

            //3 hak olacak 0-10 rastgele sayı tahmin edilecek

            /*
            Random random= new Random();
            int sayi = random.Next(10);
            int tahmin, hak=3;
            do
            {
                hak--;
                Console.WriteLine( "tahmininiz : ");
                tahmin = int.Parse( Console.ReadLine());

                if(tahmin>sayi)
                    Console.WriteLine($"daha küçük sayı giriniz.\n{hak} hakkınız kaldı");
                else if(tahmin < sayi)
                    Console.WriteLine($"daha büyük sayı giriniz. \n{hak} hakkınız kaldı");
                else
                {
                    Console.WriteLine($"tebrikler. {3-hak}. hakta bildiniz");
                    break;
                }
            }while(hak>0);
            if(hak==0)
                Console.WriteLine($"bilemediniz.Sayı {sayi} olacak.");
            Console.ReadLine();

            */

            //girilen karakter kadar rastgele kelime üreten 
            //5
            //dkldl

            /*
            Console.WriteLine("adet : ");
            int adet = int.Parse(Console.ReadLine());
            string metin = "";
            Random random= new Random();
            for (int i = 0; i < adet; i++)
            {
                metin += (char)random.Next('a','z');

            }
            Console.WriteLine(metin);
            Console.ReadLine();

            */

            //girilen paranın banknotlara ayırınız.
            //379
            //1 adet 200
            //1 adet 100
            // 1 adet 50
            // 1 adet 20
            //1 adet 5
            //4 adet 1 



            /*
            Console.Write("Para : ");
            int para = int.Parse(Console.ReadLine());
            int adet = 0;
            while (para > 0)
            {
                if (para >= 200)
                {
                    adet = Math.DivRem(para, 200, out para);
                    Console.WriteLine($"{adet} adet 200TL");
                }
                else if (para >= 100)
                {
                    adet = Math.DivRem(para, 100, out para);
                    Console.WriteLine($"{adet} adet 100TL");
                }
                else if (para >= 50)
                {
                    adet = Math.DivRem(para, 50, out para);
                    Console.WriteLine($"{adet} adet 50TL");
                }
                else if (para >= 20)
                {
                    adet = Math.DivRem(para, 20, out para);
                    Console.WriteLine($"{adet} adet 20TL");
                }
                else if (para >= 10)
                {
                    adet = Math.DivRem(para, 10, out para);
                    Console.WriteLine($"{adet} adet 10TL");
                }
                else if (para >= 5)
                {
                    adet = Math.DivRem(para, 5, out para);
                    Console.WriteLine($"{adet} adet 5TL");
                }
                else
                {
                    Console.WriteLine($"{para} adet 1TL");
                    para = 0;
                }
                    
            }
                    Console.ReadLine(); 



                        */

            //Değer(Veri) Tipler ve Referans Tipler
            /*
                Değer Tipleri= Bellekte Stack te tutulur.

                Referans Tipler =Heap te tutulur. Ref veya out kelimesi ile dönüştürülür. 
            Ref=başlangıç değeri verilmeli
            out= başlangıç değeri verilmesine gerek yok.

            */


            /*
            int a = 10, b = 10;
            Metot(a, b);
            Console.WriteLine($"a: {a} b:{b}");

            int c = 10, d;
            Metot2(ref c, out d);
            Console.WriteLine($"a: {a} b:{b}");
            Console.Read();
        }

        private static void Metot2(ref int a, out int b)
        {
            a = 5;
            b = 5;
        }

        private static void Metot(int a, int b)
        {
            a = 5;
            b = 5;
        }


            */
            //girilen 10 notun kaç tanesi 50 ve altıdır
            // açıklama satırı

            int sayi, sayac=0;
        
            for (int i = 1; i <= 10; i++)

            {
                Console.WriteLine("not giriniz");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi <= 50)
                {
                    sayac++;

                }
            }
            Console.WriteLine(sayac);
            Console.ReadLine();
            
                
             
























































    }
    }
}
