using System;

namespace metot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int a=2;
            int b=3;

            Console.WriteLine(a+b);
            
            int sonuc = Topla(a,b);
            Console.WriteLine(sonuc);

            metotlar deneme = new metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));
            
            int sonucc = ornek.ArtirVeTopla(ref a,ref b);
            deneme.EkranaYazdir(Convert.ToString(sonucc));
            deneme.EkranaYazdir(Convert.ToString(a+b));


        }

        static int Topla(int deger1,int deger2)
        {
            return (deger1+deger2);
        }
    }

    class metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArtirVeTopla(ref int deger1,ref int deger2)
        {
            deger1+=1;
            deger2+=1;
            return deger1+deger2;
        }
    }
}
