using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"İşlem yapılmak istenen geometrik şekli kullanıcıdan alınmalı (Daire, Üçgen, Kare, Dikdörtgen vb..)
            //Seçilen şekle göre, kenar bilgilerin kullanıcıdan alınmalı)"
            //Hesaplanmak istenen boyutu kullanıcıdan alınmalı (Çevre, Alan, Hacim vb..)
            //Hesap sonucunu anlaşılır şekilde geri döndürmeli.
            Alan alan=new Alan();
            Console.WriteLine("İşlem yapılmak istenen geometrik şekli giriniz.(Daire, Üçgen, Kare, Dikdörtgen vb..)");
            string secim=Console.ReadLine();

            if (secim=="Daire")
            {
                Console.WriteLine("Dairenin yarı çapını giriniz.");
                double yarıcapGiris=Double.Parse(Console.ReadLine());
                Console.WriteLine("Dairenin alanı: "+alan.daireAlan(yarıcapGiris));
                Console.WriteLine("Dairenin Cevresi: "+alan.daireCevre(yarıcapGiris));
                Console.WriteLine("Kürenin Hacmi: "+alan.daireHacim(yarıcapGiris));
            }
            else if (secim=="Üçgen")
            {
                Console.WriteLine("Üçgenin kenarlarını araya virgül koyarak yanyana yazınız.En sona yüksekliği yazınız");
                string[] kenarGiris=Console.ReadLine().Split(",");
                int k1=int.Parse(kenarGiris[0]);
                int k2=int.Parse(kenarGiris[1]);
                int k3=int.Parse(kenarGiris[2]);
                int k4=int.Parse(kenarGiris[3]);
                Console.WriteLine("Üçgenin alanı: "+alan.ücgenAlan(k1,k2,k3));  
                Console.WriteLine("Üçgenin Cevresi: "+alan.ücgenCevre(k1,k2,k3));
                Console.WriteLine("Üçgenin Hacmi: "+alan.ücgenHacim(k1,k2,k3,k4));              
            }
            else if (secim=="Kare")
            {
                Console.WriteLine("Karenin kenarını giriniz..");
                Console.WriteLine("karenin Alanı: "+alan.KaraAlan(int.Parse(Console.ReadLine())));  
                Console.WriteLine("karenin Cevresi: "+alan.KaraCevre(int.Parse(Console.ReadLine())));
                Console.WriteLine("Küpün Hacmi: "+alan.KaraHacim(int.Parse(Console.ReadLine())));        
            }
            else if (secim=="Dikdörtgen")
            {
                Console.WriteLine("Dikdörtgenin kısa ve uzun kenarını araya virgül koyarak giriniz");
                string[] kenarGiris1=Console.ReadLine().Split(",");
                int d1=int.Parse(kenarGiris1[0]);
                int d2=int.Parse(kenarGiris1[1]);
                int d3=int.Parse(kenarGiris1[2]);
                Console.WriteLine("Dikdörtgenin Alanı: "+alan.DikdörtgenAlan(d1,d2));
                Console.WriteLine("Dikdörtgenin Cevresi: "+alan.DikdörtgenCevre(d1,d2));
                Console.WriteLine("Dikdörtgenin Hacmi: "+alan.DikdörtgenHacim(d1,d2,d3));
            }
            else             
                Console.WriteLine("Yanlış giriş yapıldı.");          
        }     
    }

    public class Alan
    {

        public int KaraAlan(int kenar)
        {
            return kenar*kenar;
        }
        public int KaraCevre(int kenar)
        {
            return kenar*4;
        }
        public int KaraHacim(int kenar)
        {
            return kenar*kenar*kenar;
        }


        public int DikdörtgenAlan(int kısaKenar, int UzunKenar)
        {
            return kısaKenar*UzunKenar;
        }
        public int DikdörtgenCevre(int kısaKenar, int UzunKenar)
        {
            return (kısaKenar+UzunKenar)*2;
        }
        public int DikdörtgenHacim(int kısaKenar, int UzunKenar,int yukseklik)
        {
            return kısaKenar+UzunKenar*yukseklik;
        }
        public double ücgenAlan(int kenar1, int kenar2, int kenar3)
        {
            int alan=(kenar1+kenar2+kenar3)*(-kenar1+kenar2+kenar3)*(kenar1-kenar2+kenar3)*(kenar1+kenar2-kenar3);
            return Math.Sqrt(Convert.ToDouble(alan/16));
        }
        public int ücgenCevre(int kenar1, int kenar2, int kenar3)
        {
            return kenar1+kenar2+kenar3;
        }
        public double ücgenHacim(int kenar1, int kenar2, int kenar3, int yukseklik)
        {
            int alan=(kenar1+kenar2+kenar3)*(-kenar1+kenar2+kenar3)*(kenar1-kenar2+kenar3)*(kenar1+kenar2-kenar3)/16;
            return Convert.ToDouble(Math.Sqrt(alan)*yukseklik/3);
        }
        public double daireAlan(double yarıcap)
        {
            return 3.14*yarıcap*yarıcap;
             
        }
        public double daireCevre(double yarıcap)
        {
            return 2*3.14*yarıcap;
             
        }
        public double daireHacim(double yarıcap)
        {
            return 4/3*3.14*yarıcap*yarıcap*yarıcap;
             
        }
            
    }
}

