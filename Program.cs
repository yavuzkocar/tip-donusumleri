using System;

namespace tip_donusumleri
{
    class Program
    {
        private const int V = 4;

        static void Main(string[] args)
        {
           //Implicit Conversion (Bilinçsiz ya da kapalı dönüşüm)
           byte a = 5;
           sbyte b = 38;
           short c = 18;

           int d = a+b+c;

           Console.WriteLine("d:" + d);


           //Explicit Conversion (Bilinçli ya da açık dönüşüm)
           
           Console.WriteLine("*****Explicit Conversion*****") ;

           int g = 5;
           byte y = (byte)g;
           Console.WriteLine("y: "+y);

           //ToString metodu
           Console.WriteLine("*****ToString metodu*****") ;
           int aa = 54;
           string bb = aa.ToString();
           Console.WriteLine("bb: " +bb);

           //System.Convert 
           Console.WriteLine("*****System.Convert*****") ;

           string s1 = "12" , s2 = "13" ;
           int sayı1 , sayı2 ;
           int toplam;
           sayı1 = Convert.ToInt32(s1);
           sayı2 = Convert.ToInt32(s2);
           toplam = sayı1 + sayı2 ;
           Console.WriteLine("toplam=" + toplam);
           
           //parse
           Console.WriteLine("*****parse method*****") ;
           parseMethod() ;
        }
        public static void parseMethod()
        {
            string metin1 = "10", metin2 =" 10,2" ;
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = double.Parse(metin2);

            Console.WriteLine(rakam1);
            Console.WriteLine(double1);
        }
    } 
}
