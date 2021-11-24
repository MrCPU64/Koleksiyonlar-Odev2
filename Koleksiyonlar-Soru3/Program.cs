using System;
using System.Collections;

namespace Koleksiyonlar_Soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList sesliHarfler = new ArrayList();
            sesliHarfler.Add('a');
            sesliHarfler.Add('e');
            sesliHarfler.Add('ı');
            sesliHarfler.Add('i');
            sesliHarfler.Add('o');
            sesliHarfler.Add('ö');
            sesliHarfler.Add('u');
            sesliHarfler.Add('ü');
            sesliHarfler.Add('A');
            sesliHarfler.Add('E');
            sesliHarfler.Add('I');
            sesliHarfler.Add('İ');
            sesliHarfler.Add('O');
            sesliHarfler.Add('Ö');
            sesliHarfler.Add('U');
            sesliHarfler.Add('Ü');
            

            string cumle = Console.ReadLine();

            ArrayList cumleIciSesliHarfler = new ArrayList();
            for (int i = 0; i < cumle.Length; i++)
            {
                if(sesliHarfler.Contains(Convert.ToChar(cumle[i])))
                    cumleIciSesliHarfler.Add(cumle[i]);
            }
            
            cumleIciSesliHarfler.Sort();
            foreach (var item in cumleIciSesliHarfler)
            {
                Console.WriteLine(item);
            }


        }
    }
}
