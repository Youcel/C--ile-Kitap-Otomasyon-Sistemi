using System;

namespace NTP_Proje
{
    class Program
    {
     

        static void Main(string[] args)
        {

            Console.WriteLine("*********************************************************************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("** Türkçe Kitaplar Kategorisi ** Yabancı  Kitaplar Kategorisi **  ");
            Console.WriteLine();
            Console.WriteLine("** 1-Çalıkuşu:Reşat Nuri Güntekin ** 7-Tuna Kılavuzu:Jules Verne**  ");
            Console.WriteLine();
            Console.WriteLine("** 2-Yaban:Yakup Kadri ** 8-Martin Eden:Jack London**  ");
            Console.WriteLine();
            Console.WriteLine("** 3-Ateşten Gömlek:Halide Edip  ** 9-Altıncı Koğuş:Anton Çehov**  ");
            Console.WriteLine();
            Console.WriteLine("** 4-Tutunamayanlar:Oğuz Atay ** 10-Kumarbaz:Dostoyevski **  ");
            Console.WriteLine();
            Console.WriteLine("** 5-Nutuk:M.Kemal ** 11-Beyaz Zambaklar Ülkesinde:Grigoriy Petrov  **  ");
            Console.WriteLine();
            Console.WriteLine("** 6-Kuyucaklı Yusuf:S.Ali** 12-Babalar ve oğulları:Turgenyev **  ");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine();
            Console.WriteLine("************ İşlemler Menüsü *******************");
            Console.WriteLine("1-Fiyat Sorgulama");
            Console.WriteLine("2-Yeni Okur Kaydı");
            Console.WriteLine("3-Günün Kitabı");
            Console.WriteLine("4-Oyun");
            Console.WriteLine();
            Console.Write("Yapmak İstediğiniz işlemin numarası:");
            char islem;
            islem = Convert.ToChar(Console.ReadLine());
            if (islem=='1')
            {
                Console.WriteLine("işlem:Fiyat sorgulama");

            }

            if (islem == '2')
            {
                Console.WriteLine("işlem:Yeni Okur Kaydı");

            }
            if (islem == '3')
            {
                Console.WriteLine("işlem:Günün Kitabı");

            }
            if (islem == '4')
            {
                Console.WriteLine("işlem:Oyun");

            }
         
            Console.WriteLine();
            Console.Write("işlem:Lütfen fiyatını öğrenmek istediğiniz kıtabın numarasını giriniz:");
            string numara;
            numara = Console.ReadLine();
            switch (numara)
            {
                case "1":Console.Write("Çalıkuşu:12 TL"); break;
                case "2": Console.Write("Yaban:15 TL"); break;
                case "3": Console.Write("ateşten gömlek:17 TL"); break;
                case "4": Console.Write("Tutunamayanlar:37 TL"); break;
                case "5": Console.Write("Nutuk:35 TL"); break;
                case "6": Console.Write("Kuyucaklı Yusuf:19 TL"); break;
                case "7": Console.Write("Tuna Kılavuzu:19 TL"); break;
                case "8": Console.Write("Martin Eden:19 TL"); break;
                case "9": Console.Write("Altıncı Koğuş:5 TL"); break;
                case "10": Console.Write("Kumarbaz:19 TL"); break;
                case "11": Console.Write("Beyaz Zambaklar Ülkesinde:19 TL"); break;
                case "12": Console.Write("Babalar ve Oğulları:23 TL"); break;
                default:Console.WriteLine("Böyle bir kitap mevcut değil,numarayı kontrol edin");break;








            }

            Console.WriteLine("************* Yeni Okur Kaydı ******** ");
            string ad, soyad, üniversite;
            Console.WriteLine("adınız");
            ad = Console.ReadLine();
            Console.WriteLine("soyadınız");
            soyad = Console.ReadLine();
            Console.WriteLine("Üniversiteniz");
            üniversite = Console.ReadLine();
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("günün kitabı:Nutuk");
            int tahmin = 0;
            Random rnd = new Random();
            int sayı = rnd.Next(1, 100);
            while (sayı!=tahmin)
            {

                Console.WriteLine("sayı giriniz");
                tahmin = Convert.ToInt32(Console.ReadLine());
                if (tahmin>sayı)
                {
                    Console.Write("daha küçük");
                }

                if (tahmin<sayı)
                {
                    Console.Write("Daha büyük");

                }
                if (tahmin==sayı)
                {
                    Console.Write("bildiniz");
                    break;

                }
                Console.ReadKey();



            }



        }
    }
}
