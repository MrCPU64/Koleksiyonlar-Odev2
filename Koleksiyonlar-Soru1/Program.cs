using System;
using System.Collections;

namespace Koleksiyonlar_Soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ArrayList asalListe = new ArrayList();
                ArrayList asalOlmayanListe = new ArrayList();
                int count = 0;

                do
                {
                    uint input = uint.Parse(Console.ReadLine().Trim());
                    int checkCount = 0;
                    for(int i = 1; i<=input; i++)
                    {
                        if(input%i==0)
                            checkCount++;
                    }
                    if(checkCount == 2)
                        asalListe.Add(input);
                    else
                        asalOlmayanListe.Add(input);
                

                    count++;
                }
                while(count<5);


                asalListe.Sort();
                asalListe.Reverse();
                asalOlmayanListe.Sort();
                asalOlmayanListe.Reverse();

                Console.WriteLine("***** Asal Sayılar ******");
                foreach (var item in asalListe)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("***** Asal Olmayan Sayılar ******");
                foreach (var item in asalOlmayanListe)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("Asal Liste Eleman Sayısı: " + asalListe.Count);
                Console.WriteLine("Asal Olmayan Liste Eleman Sayısı: " + asalOlmayanListe.Count);
                
                uint sumAsal = 0;
                foreach (uint item in asalListe)
                {
                    sumAsal+=item;

                }

                double asalOrt = (double)sumAsal / asalListe.Count;
                Console.WriteLine("Asal Sayıların Ortalaması: " + asalOrt);

                uint sumAsalOlmayan = 0;
                foreach (uint item in asalOlmayanListe)
                {
                    sumAsalOlmayan+=item;

                }

                double asalOlmayanOrt = (double)sumAsalOlmayan / asalOlmayanListe.Count;
                Console.WriteLine("Asal Olmayan Sayıların Ortalaması: " + asalOlmayanOrt);

            }
            catch(FormatException)
            {
                Console.WriteLine("Numeric olmayan bir değer girdiniz. Tekrar deneyin.");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Negatif bir değer girdiniz. Tekrar deneyin.");
            }

            
            
        }


    }
}
