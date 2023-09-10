using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sınav başlaması için Y harfine basarak onay veriniz.");
            string verification = Console.ReadLine();
            if (verification == "Y")
            {
                Console.WriteLine("Sınavınız başlamıştır. Başarılar dilerim... ");
            }
            else Console.WriteLine("Sınavınız başlatılamamıştır."); 
            Console.ReadKey();
            Console.WriteLine();
            int question = 1;
            string answer;
            if(question == 1)
            {
                Console.WriteLine(" Soru 1: İnt ne tipidir?");
                Console.WriteLine("A)Değer tipi");
                Console.WriteLine("B)Referans tipi");
                Console.WriteLine("C)Char tipi ");
                Console.WriteLine("D)Değer tipi yoktur");
                Console.WriteLine();
                Console.Write("Cevabınız:  ");
                answer = Console.ReadLine();

                if(answer == "a" || answer =="A")
                {
                    Console.WriteLine("Cevabınız doğru ");
                    question= question+ 1 ;
                }
                else { Console.WriteLine("Cevabınız hatalı, başarı puanınız: 0"); }
                Console.ReadKey();
                Console.Clear();
            }
            if (question == 2)      
            {
                Console.WriteLine();
                Console.WriteLine("Soru 2:String ne tipidir ?");
                Console.WriteLine("A)Değer tipi");
                Console.WriteLine("B)Char tipi ");
                Console.WriteLine("C)Tipi yoktur");
                Console.WriteLine("D)Referans tipi ");
                Console.WriteLine();
                Console.WriteLine("Cevabınız: ");
                answer= Console.ReadLine();
                if (answer == "d" || answer == "D")
                {
                    Console.WriteLine("Cevabınız doğru ");
                    question = question + 1;
                }
                else { Console.WriteLine("Cevabınız hatalı, başarı puanınız:1 "); }
                Console.ReadKey();
                Console.Clear();
            }
            if (question == 3)
            {
                Console.WriteLine();
                Console.WriteLine("Soru 3:Yapıcı metodlar birden fazla olabilir mi ?");
                Console.WriteLine("A)Evet olabilir");
                Console.WriteLine("B)Hayır olamaz ");
                Console.WriteLine();
                Console.WriteLine("Cevabınız: ");
                answer = Console.ReadLine();
                if (answer == "a" || answer == "A")
                {
                    Console.WriteLine("Cevabınız doğru ");
                    question = question + 1;
                }
                else { Console.WriteLine("Cevabınız hatalı, başarı puanınız:2 "); }
                Console.ReadKey();
                Console.Clear();
            }
            if (question == 4)
            {
                Console.WriteLine();
                Console.WriteLine("Soru 4: Yıkıcı metodlar birden fazla olabilir mi ?");
                Console.WriteLine("A)Evet olabilir");
                Console.WriteLine("B)Hayır olamaz ");
                Console.WriteLine();
                Console.WriteLine("Cevabınız: ");
                answer = Console.ReadLine();
                if (answer == "b" || answer == "B")
                {
                    Console.WriteLine("Cevabınız doğru ");
                    question = question + 1;
                }
                else { Console.WriteLine("Cevabınız hatalı, başarı puanınız:3 "); }
                Console.ReadKey();
                Console.Clear();
            }
            if (question == 5)
            {
                Console.WriteLine();
                Console.WriteLine("Soru 5: Referans tipi newlenebilir mi ? ");
                Console.WriteLine("A)Evet ");
                Console.WriteLine("B)Hayır  ");
                Console.WriteLine();
                Console.WriteLine("Cevabınız: ");
                answer = Console.ReadLine();
                if (answer == "a" || answer == "A")
                {
                    Console.WriteLine("Cevabınız doğru ");
                    question = question + 1;
                }
                else { Console.WriteLine("Cevabınız hatalı, başarı puanınız:4 "); }
                Console.ReadKey();
                Console.Clear();
            }
            if (question == 6)
            {
                Console.WriteLine();
                Console.WriteLine("Soru 6: Aşağıdakilerden hangisi döngü için kullanılmaz? ");
                Console.WriteLine("A)For");
                Console.WriteLine("B)While ");
                Console.WriteLine("C)Array ");
                Console.WriteLine("D)Do while");
                Console.WriteLine();
                Console.WriteLine("Cevabınız: ");
                answer = Console.ReadLine();
                if (answer == "c" || answer == "C")
                {
                    Console.WriteLine("Cevabınız doğru ");
                    question = question + 1;
                }
                else { Console.WriteLine("Cevabınız hatalı, başarı puanınız:5 "); }
                Console.ReadKey();
                Console.Clear();
            }
            if (question == 7)
            {
                Console.WriteLine();
                Console.WriteLine("Soru 7: Aşağıdakilerden hangisi karar yapısıdır");
                Console.WriteLine("A)List");
                Console.WriteLine("B)Const ");
                Console.WriteLine("C)Convert ");
                Console.WriteLine("D)İf else ");
                Console.WriteLine();
                Console.WriteLine("Cevabınız: ");
                answer = Console.ReadLine();
                if (answer == "d" || answer == "D")
                {
                    Console.WriteLine("Cevabınız doğru ");
                    question = question + 1;
                }
                else { Console.WriteLine("Cevabınız hatalı, başarı puanınız:6 "); }
                Console.ReadKey();
                Console.Clear();
            }
            if (question == 8)
            {
                Console.WriteLine();
                Console.WriteLine("Soru 8: Const ne için kullanılır? )");
                Console.WriteLine("A)Değişkenin değerini sabitlemek  ");
                Console.WriteLine("B)Döngü başlatmak ");
                Console.WriteLine("C)Yapıcı metod başlatmak ");
                Console.WriteLine("D)Yıkıcı metod başlatmak");
                Console.WriteLine();
                Console.WriteLine("Cevabınız: ");
                answer = Console.ReadLine();
                if (answer == "a" || answer == "A")
                {
                    Console.WriteLine("Cevabınız doğru ");
                    question = question + 1;
                }
                else { Console.WriteLine("Cevabınız hatalı, başarı puanınız:7 "); }
                Console.ReadKey();
                Console.Clear();
            }
            if (question == 9)
            {
                Console.WriteLine();
                Console.WriteLine("Soru 9: ctrl+K+D ne çin kullanılır )");
                Console.WriteLine("A)Değişkenin değerini sabitlemek  ");
                Console.WriteLine("B)Kodu düzenlemek  ");
                Console.WriteLine("C)Yapıcı metod başlatmak ");
                Console.WriteLine("D)Döngü oluşturmak");
                Console.WriteLine();
                Console.WriteLine("Cevabınız: ");
                answer = Console.ReadLine();
                if (answer == "b" || answer == "B")
                {
                    Console.WriteLine("Cevabınız doğru ");
                    question = question + 1;
                }
                else { Console.WriteLine("Cevabınız hatalı, başarı puanınız:8 "); }
                Console.ReadKey();
                Console.Clear();
            }
            if (question == 10)
            {
                Console.WriteLine();
                Console.WriteLine("Soru 10: ctrl+K+U  ne için kullanılır? )");
                Console.WriteLine("A)Yorum satırı oluşturmak ");
                Console.WriteLine("B)Yorum satırından çıkmak");
                Console.WriteLine("C)Yapıcı metod başlatmak ");
                Console.WriteLine("D)Kodu düzenlemek");
                Console.WriteLine();
                Console.WriteLine("Cevabınız: ");
                answer = Console.ReadLine();
                if (answer == "b" || answer == "B")
                {
                    Console.WriteLine("Tebrikler sınavınız bitti tüm soruları doğru cevapladınız :) ");
                    
                }
                else { Console.WriteLine("Cevabınız hatalı, başarı puanınız:9 "); }
                Console.ReadKey();
                Console.Clear();
            }
        }
        
    } 
}


