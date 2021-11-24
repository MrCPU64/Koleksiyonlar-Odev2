using System;
using System.Collections;

namespace Koleksiyonlar_Soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList sayiListesi = new ArrayList();

            for(int i = 0; i < 20; i++)
            {
                sayiListesi.Add(Console.ReadLine());
            }

            int temp = 0;
            for (int i = 0; i < sayiListesi.Count-1; i++)
            {
                for (int j = 0; j < sayiListesi.Count-i-1; j++)
                {
                    if(Convert.ToInt32(sayiListesi[j])>Convert.ToInt32(sayiListesi[j+1]))
                    {
                        temp = Convert.ToInt32(sayiListesi[j]);
                        sayiListesi[j] = sayiListesi[j+1];
                        sayiListesi[j+1] = temp;


                    }


                }
            }


            ArrayList enBuyuk3SayiListe = new ArrayList();
            ArrayList enKucuk3SayiListe = new ArrayList();

            Console.WriteLine("***** En Küçük 3 Sayı *****");
            for(int i = 0; i < 3; i++)
            {
                enKucuk3SayiListe.Add(sayiListesi[i]);
                Console.WriteLine(sayiListesi[i]);
            }

            Console.WriteLine("***** En Büyük 3 Sayı ******");
            for (int i = sayiListesi.Count-1; i >= sayiListesi.Count-3; i--)
            {
                enBuyuk3SayiListe.Add(sayiListesi[i]);
                Console.WriteLine(sayiListesi[i]);
            }


            int sumBuyuk = 0;
            int sumKucuk = 0;

            for(int i = 0; i<3; i++)
            {
                sumBuyuk+=Convert.ToInt32(enBuyuk3SayiListe[i]);
                
            }

            for(int i = 0; i<3; i++)
            {
                sumKucuk+=Convert.ToInt32(enKucuk3SayiListe[i]);
                
            }

            Console.WriteLine("En Buyuk 3 Sayı Ortalama : " + (double)sumBuyuk/enBuyuk3SayiListe.Count);
            Console.WriteLine("En Kucuk 3 Sayı Ortalama : " + (double)sumKucuk/enKucuk3SayiListe.Count);
            double ortTop = (double)sumBuyuk/enBuyuk3SayiListe.Count + (double)sumKucuk/enKucuk3SayiListe.Count;
            Console.WriteLine("Ortalama Toplamları : " + ortTop);
            


        }
    }
}
