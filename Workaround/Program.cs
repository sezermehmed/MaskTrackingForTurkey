using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Transactions;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            Vatandas vatandas1 = new Vatandas();

            SelamVer(" Engin");
            SelamVer(" Ahmet");
            SelamVer(" Ayse");
            SelamVer();

            int sonuc = Topla(3, 5);

            // Arrays
            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";

            ogrenciler = new string[4];
            ogrenciler[3] = "ilker";
            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "Istanbul", "Izmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakir" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.Firstname = "SEZER";
            person1.Lastname = "GÖNÜLCE";
            person1.DateOfBirthYear = 1998;
            person1.NationalIdentitiy = 11381527468;

            Person person2 = new Person();
            person2.Firstname = "Murat";

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }
            //Mylist
            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "Istanbul 1 ", "Izmir 1" };

            yeniSehirler1.Add("Adana 1");

            foreach(var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }
            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);


            

            Console.ReadLine();
        }

      
       static void SelamVer(string isim = " isimsiz")
        {
             Console.WriteLine("Merhaba" + isim );
        } 
        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
        int sonuc = sayi1 + sayi2;
        Console.WriteLine("Tolpam: " + sonuc.ToString());
        return sonuc;
        }
        private static void Degiskenler()
        {
            string mesaj = "merhaba";
            double tutar = 10000;
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Engin";
            string soyad = "Demirog";
            int dogumYili = 1985;
            long tcNo = 12345678910;
        }
        public class Vatandas
        {
            string ad = "Engin";
            string soyad = "Demirog";
            int dogumYili = 1985;
            long tcNo = 12345678910;
        }
    }
   
 
}
