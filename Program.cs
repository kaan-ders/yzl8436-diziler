using System.Collections;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //c# 3 tipte dizi yapısı

            //diziler, array

            /*
             * 1) sabit bir boyutu vardır
             * 2) aynı tipte olmalıdırlar
             */

            //string isim1, isim2, isim3, isim4;

            //string isim = "ahmet";

            //var a = isim[3];
            //isim.Length

            //string[] isimler = new string[3];

            //isimler[0] = "ahmet";
            //isimler[1] = "mehmet";
            //isimler[2] = "ayşe";
            //isimler[3] = 34;
            //isimler[3] = "fatma";

            /*for (int i = 0; i < isimler.Length; i++)
            {
                for (int j = isimler[i].Length - 1; j >= 0; j--)
                {
                    Console.Write(isimler[i][j]);
                }

                Console.WriteLine();
            }*/


            /*0        1         2
            "ahmet", "mehmet", "ayşe"*/

            //string isim = "ahmet ayşe fatma bilgeadam"; //dsa
            //isim.Length
            //isim[2] -d

            //string deger = "", deger2 = "";
            //for (int i = isim.Length - 1; i >= 0; i--)
            //{
            //    //deger += isim[i];
            //    //deger2 = isim[i].ToString();
            //    Console.Write(isim[i]);
            //}

            //for (int i = 1; i <= isim.Length; i++)
            //{
            //    Console.Write(isim[isim.Length - i]);
            //}

            //int[] sayilar = new int[10];
            //sayilar[0] = 1;
            //sayilar[1] = 2;

            //bir önceki sayıyla toplamları
            //int[] sayilar = { 1342, 21, 332, 4456, 57, 698, 790, 38, 19, 12 };
            //int sonuc = 0;

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    /*if(i > 0)
            //        Console.WriteLine(sayilar[i] + ": " + (sayilar[i] + sayilar[i - 1]));
            //    else
            //        Console.WriteLine(sayilar[i]);*/

            //    //Console.WriteLine(i > 0 ? (sayilar[i] + sayilar[i - 1]) : sayilar[i]);

            //    sonuc += sayilar[i];
            //    Console.WriteLine(sayilar[i] + ": " + sonuc);
            //}

            /*"Kupa"
            "Maça"
            "Karo"
            "Sinek"*/



            /*"Kupa|1"
            "Kupa|2"
            "Kupa|3"
            "Maça|1"
            "Maça|2"*/

            //string[] deste = new string[52];
            //string[] kagit = { "Kupa", "Karo", "Maça", "Sinek" };

            //for (int i = 0; i < kagit.Length; i++)
            //{
            //    for (int j = 0; j < 13; j++)
            //    {
            //        deste[i * j] = kagit[i] + "|" + (j + 1);
            //    }
            //}

            //foreach
            //------------------------------------------

            //string[] ogrenciler = { "Ali", "Veli", "Ayşe", "Fatma" };

            //for ile

            //for (int i = 0; i < ogrenciler.Length; i++)
            //{
            //    Console.WriteLine(ogrenciler[i]);
            //}

            //foreach ile
            //foreach (string item in ogrenciler)
            //{
            //    Console.WriteLine(item);
            //}

            //ArrayList

            //ogrenciler.Reverse();
            //Array.Sort(ogrenciler);

            //Array.IndexOf(ogrenciler, "Ayşe");

            //string isim = "ahmet";
            //isim.IndexOf('e');

            //string[] oyuncular = { "Oyuncu1|20", "Oyuncu2|2" };

            //oyuncular[1].IndexOf("|")
            //Array.

            //int asd = 32;

            //decimal asd2 = 32131;
            //DateTime dateTime = DateTime.Now;

            //ArrayList liste = new ArrayList();
            //liste.Add(12);
            //liste.Add("Merhaba");
            //liste.Add(DateTime.Now);
            ////liste.Add(null);
            //liste.Add(true);

            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item + " " + item.GetType());

            //    //if(item.GetType() == typeof(int))
            //    //{
            //    //    Console.WriteLine(Convert.ToInt32(item) + 10);
            //    //}
            //}
            

            Console.ReadLine();
        }
    }
}