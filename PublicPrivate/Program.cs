using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriBilgi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // public: her yerden erişilir
            // private : sadece tanımlandığı sınıf tarafından erişilir
            Müsteri musteri1 = new Müsteri();

            musteri1.isim = "Pınar";
            musteri1.soyisim = "Altınkaya";
            musteri1.maasDegeri = 25000;
            musteri1.cinsiyet = "Kadın";

            musteri1.musteriBilgileri();
            
            Console.ReadLine();



        }
    }
}
