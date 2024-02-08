

using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    class Program
    {
        public static void Main(string[] args)
        {
            SelamVer("KErem");
            SelamVer();

            int sonuc = Topla(3, 5);

            //Diziler
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

            foreach (string eleman in ogrenciler)
            {
                Console.WriteLine(eleman);
                
            }

            List<string> yeniSehirler = new List<string>
            {
                "İzmir", "Ankara", "İstanbul"
            };

            foreach (var item in yeniSehirler)
            {
                Console.WriteLine(item);
            }

            int sayi1 = 1;
            int sayi2 = 2;
            sayi2 = sayi1;
            sayi1 = 30;
            Console.WriteLine(sayi2);

            Person person1 = new Person();
            person1.FirstName = "Kerem Can";
            person1.LastName = "Özcan";
            person1.DateOfBirthYear = 1995;
            person1.NationalIdentity = 43045527842;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);







            Console.ReadLine();
        }

        static void SelamVer(string isim="isimsiz")
        {
            Console.WriteLine("Merhaba" + isim);
        }

 

        static int Topla(int sayi1= 5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + sonuc);
            return sonuc;
        }
    }
}