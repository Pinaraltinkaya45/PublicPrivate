using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriBilgi
{
    public class Müsteri
    {
        public string isim;
        public string soyisim;
        public int maasDegeri;
        public string cinsiyet;
        private int yas;

        public Müsteri()
        {
            Console.WriteLine("Müsteri Sınıfının Yapıcı Metotu Çalıştı"); 
        }
        public void musteriBilgileri()
        {
            Console.WriteLine("İsim: " + isim);
            Console.WriteLine("Soyisim: " + soyisim);
            Console.WriteLine("Maaş Değeri : " + maasDegeri);
            Console.WriteLine("Cinsiyet: " + cinsiyet);
           // Console.WriteLine("Yas Degeri: " + yas);
        }

        private void IsimSoyisimYazdir(string musteriismi,string musterisoyismi)
        {
            Console.WriteLine("Müşterinin ismi ve soyismi : " + musteriismi + " " + musterisoyismi);

        }
    }
}
