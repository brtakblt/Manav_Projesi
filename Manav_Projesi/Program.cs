using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Threading;

namespace Manav_Projesi
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<string> meyveListesi = new List<string>
 {
     "Elma",
     "Armut",
     "Muz",
     "Nar",
     "Portakal"
 };

            List<string> sebzeListesi = new List<string>
 {
     "Pırasa",
     "Salatalık",
     "Domates",
     "Patates",
     "Soğan"
 };

            List<int> alınanMeyveKilosu = new List<int>();
            List<int> alınanSebzeKilosu = new List<int>();

            List<string> alınanMeyveler = new List<string>();
            List<string> alınanSebzeler = new List<string>();

            List<int> alınanKilo = new List<int>();
            List<string> alınanUrun = new List<string>();


            while (true)
            {
                Console.WriteLine("1-) Meyve");
                Console.WriteLine("2-) Sebze");
                Console.WriteLine("3-) Ürün Alma");
                string secim = Console.ReadLine();
                if (secim == "1")
                {
                    Console.WriteLine("Meyve seçiniz");
                    for (int i = 0; i < meyveListesi.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}-) {meyveListesi[i]}");
                    }
                    int meyveSecimi = Convert.ToInt32(Console.ReadLine());
                    if (meyveSecimi >= 1 && meyveSecimi <= meyveListesi.Count)
                    {
                        Console.WriteLine($"Seçtiğiniz meyve {meyveListesi[meyveSecimi - 1]}");
                        Console.WriteLine("Kaç kilo alacaksınız");
                        int kilo = Convert.ToInt32(Console.ReadLine());
                        alınanMeyveKilosu.Add(kilo);
                        alınanMeyveler.Add(meyveListesi[meyveSecimi - 1]);
                        Console.WriteLine($"{meyveListesi[meyveSecimi - 1]} için {kilo} kilo aldınız");
                    }
                }
                else if (secim == "2")
                {
                    Console.WriteLine("Sebze seçiniz");
                    for (int i = 0; i < sebzeListesi.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}-) {sebzeListesi[i]}");
                    }
                    int sebzeSecimi = Convert.ToInt32(Console.ReadLine());
                    if (sebzeSecimi >= 1 && sebzeSecimi <= sebzeListesi.Count)
                    {
                        Console.WriteLine($"Seçtiğiniz sebze {sebzeListesi[sebzeSecimi - 1]}");
                        Console.WriteLine("Kaç kilo alacaksınız");
                        int kilo = Convert.ToInt32(Console.ReadLine());
                        alınanSebzeKilosu.Add(kilo);
                        alınanSebzeler.Add(sebzeListesi[sebzeSecimi - 1]);
                        Console.WriteLine($"{sebzeListesi[sebzeSecimi - 1]} için {kilo} kilo aldınız");
                    }
                    else
                    {
                        Console.WriteLine("Hatalı seçim");
                    }


                }
                else if (secim == "3")

                {


                    Console.WriteLine("------MANAVA HOŞ GELDİNİZ------\n");
                    Console.WriteLine("1-)Meyve\n2-)Sebze\n3-)Ürünlerim");
                    int manavSecimi = Convert.ToInt32(Console.ReadLine());

                    if (manavSecimi == 1)
                    {
                        for (int i = 0; i < alınanMeyveler.Count; i++)
                        {
                            Console.WriteLine($"Stokdaki meyveler {i + 1}-) {alınanMeyveler[i]}");
                        }
                        Console.WriteLine("Seçiminiz:");
                        int meyveSecimi = Convert.ToInt32(Console.ReadLine())-1;
                        
                        if(meyveSecimi>-1 && meyveSecimi < alınanMeyveler.Count)
                        {
                            while (true)
                            {
                                Console.WriteLine($"Kaç kilo {alınanMeyveler[meyveSecimi]} istersiniz?");
                                int kilo = Convert.ToInt32(Console.ReadLine());

                                if (alınanMeyveKilosu[meyveSecimi] >= kilo)
                                {
                                    alınanMeyveKilosu[meyveSecimi] -= kilo;
                                    Console.WriteLine("Afiyet olsun");
                                    alınanKilo.Add(kilo);
                                    break;
                                   
                                }
                                else if (alınanMeyveKilosu[meyveSecimi] == 0)
                                {
                                    alınanMeyveKilosu.Remove(meyveSecimi);
                                    for (int i = 0; i < alınanMeyveKilosu.Count; i++)
                                    {
                                        Console.WriteLine($"{meyveSecimi} Afiyet olsun");
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Yeterli stok bulunmamaktadır. Daha az miktar giriniz.");
                                }
                            }
                           
                        }
                        else
                        {
                            Console.WriteLine("Hatalı işlem");
                        }

                    }
                    else if (manavSecimi == 2)
                    {
                        for (int i = 0; i < alınanSebzeler.Count; i++)
                        {
                            Console.WriteLine($"Stokdaki sebzeler {alınanSebzeler[i]}");

                        }
                        Console.WriteLine("Seçiminiz:");
                        int sebzeSecimi = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (sebzeSecimi >=1 && sebzeSecimi <= sebzeListesi.Count)
                        {
                            while (true)
                            {
                                Console.WriteLine($"Kaç kilo {alınanSebzeler[manavSecimi]}istersiniz");
                                int kilo = Convert.ToInt32(Console.ReadLine());
                                if (alınanSebzeKilosu[sebzeSecimi] > kilo)
                                {
                                    alınanSebzeKilosu[sebzeSecimi] -= kilo;
                                    Console.WriteLine("Afiyet olsun");
                                    alınanKilo.Add(kilo);
                                    break;
                                }
                                else if (alınanSebzeKilosu[sebzeSecimi] == 0)
                                {
                                    alınanSebzeKilosu.Remove(sebzeSecimi);
                                    Console.WriteLine("Afiyet olsun");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Yeterli stok bulunmamaktadır. Daha az miktar giriniz.");

                                }
                            }
                        }
                    }
                    else if (manavSecimi == 3)
                    {
                      
                        Console.WriteLine("Alınan ürünlerin kilosu;");
                        for (int i = 0; i < alınanKilo.Count; i++)
                        {
                            Console.WriteLine(alınanKilo[i]);
                           
                        }
                        Console.WriteLine("Alınan ürünler");
                        for (int i = 0; i < alınanUrun.Count; i++)
                        {
                            Console.WriteLine(alınanUrun[i]);

                        }
                    }

                }



                Thread.Sleep(2000);
                Console.Clear();
            }



        }
    }
}
