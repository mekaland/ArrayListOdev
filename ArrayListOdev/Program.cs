using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kullaniciSecim =string.Empty;  
            ArrayList degerListesi = new ArrayList();
            do
            {
                Console.Clear();
                Console.WriteLine("Menü");
                Console.WriteLine("1- Deger Ekle");
                Console.WriteLine("2- Deger Listele");
                Console.WriteLine("3- Deger Ara");
                Console.WriteLine("4- Deger Duzenle");
                Console.WriteLine("5- Deger Sil");
                Console.WriteLine("6- Uygulama Cıkıs");
                Console.Write("Seciniz:");
                kullaniciSecim = Console.ReadLine();

               

                switch (kullaniciSecim)
                {
                    case "1":
                        Console.Write("Lutfen eklemek istediginiz degeri giriniz: ");
                        string kullaniciDeger = Console.ReadLine();
                        degerListesi.Add(kullaniciDeger);
                        Console.Write("Degeriniz basarılı bir sekilde eklendi");
                        System.Threading.Thread.Sleep(1000);
                        break;
                    case "2":
                        for (int i = 0; i < degerListesi.Count; i++)
                        {
                            Console.WriteLine("{0}. Deger = {1}", i, degerListesi[i]);
                        }
                        Console.WriteLine("Devam etmek icin bir tusa basınız");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Aramak istediginiz degeri giriniz");
                        string kullaniciAramaDeger = Console.ReadLine();
                        bool kontrol = degerListesi.Contains("kullaniciAramaDeger");
                        if (kontrol)
                        {
                            int bulunanIndex = degerListesi.IndexOf(kullaniciAramaDeger);
                            string bulunanDeger = degerListesi[bulunanIndex].ToString();
                            Console.WriteLine(" Deger bukundu : index sırası : {0} Deger : {1}", bulunanIndex, bulunanDeger);
                        }
                        else
                        {
                            Console.WriteLine("Aradıgınız degerlerde bir kriter bulunamadı");
                        }
                        System.Threading.Thread.Sleep(1000);
                        break;
                    case "4":
                        Console.WriteLine("Hangi degeri guncellemek istiyorsunuz:");
                        string kullaniciDuzenleDeger = Console.ReadLine();

                        Console.WriteLine("{0} degerini hangi deger ile guncellemek istiyorsunuz", kullaniciDuzenleDeger);
                        string kullaniciYeniDeger = Console.ReadLine();
                        if(degerListesi.Contains(kullaniciDuzenleDeger))
                        {
                            int kullaniciHedefIndex = degerListesi.IndexOf(kullaniciDuzenleDeger);
                            // bu degerin indexine ulasmya calısıyoruz
                            degerListesi[kullaniciHedefIndex] = kullaniciYeniDeger;
                            Console.WriteLine("Degeriniz guncellendi");
                        }
                        else
                        {
                            Console.WriteLine("Aradıgınız deger liste icerisiinde bulunamadı") ;
                        }
                        System.Threading.Thread.Sleep(1000);
                        break;
                    case "5":
                        Console.WriteLine("tum degerleri mi silmek istiyorsunuz (E/H)");
                        string kullaniciSilCevap = Console.ReadLine();
                        if(kullaniciSilCevap.ToUpper()== "E")
                        {
                            degerListesi.Clear();
                            Console.WriteLine("tum degerler silindi");
                        }
                        else
                        {
                            Console.WriteLine("silmek istediginiz degeri giriniz");
                            string kullaniciSilDeger = Console.ReadLine();
                            if (degerListesi.Contains(kullaniciSilDeger))
                            {
                                degerListesi.Remove(kullaniciSilDeger);
                                Console.WriteLine("deger silindi");
                            }
                            else
                            {
                                Console.WriteLine("Silmek istediginiz deger liste iceriside mevut degil");
                            }
                        }
                        break;
                }
            } while (kullaniciSecim != "6");
        }
    }
}
