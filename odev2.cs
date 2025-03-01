
//soru1

//using System;

//namespace DigitSumCalculator
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Bir sayı giriniz: ");
//            if (int.TryParse(Console.ReadLine(), out int number))
//            {
//                int sum = CalculateDigitSum(number);
//                Console.WriteLine($"Rakamların toplamı: {sum}");
//            }
//            else
//            {
//                Console.WriteLine("Geçerli bir sayı giriniz.");
//            }
//        }

//        static int CalculateDigitSum(int number)
//        {
//            number = Math.Abs(number);
//            int sum = 0;

//            for (; number > 0; number /= 10)
//            {
//                sum += number % 10;
//            }

//            return sum;
//        }
//    }
//}

//soru2

//using System;

//class Program
//{
//    static void Main()
//    {
//        int number;

//        while (true)
//        {
//            Console.Write("Lütfen 10 ile 100 arasında bir sayı girin: ");

//            if (int.TryParse(Console.ReadLine(), out number))
//            {
//                if (number >= 10 && number <= 100)
//                {
//                    Console.WriteLine("Geçerli sayı girildi: " + number);
//                    break;
//                }
//                else
//                {
//                    Console.WriteLine("Hata: Sayı 10 ile 100 arasında olmalıdır.");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Hata: Geçerli bir sayı giriniz.");
//            }
//        }
//    }
//}

//soru3

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Kaç kişi olduğunu giriniz: ");
//        int kisiSayisi = int.Parse(Console.ReadLine());
//        int[] yaslar = new int[kisiSayisi];

//        for (int i = 0; i < kisiSayisi; i++)
//        {
//            Console.Write($"{i + 1}. kişinin yaşını giriniz: ");
//            yaslar[i] = int.Parse(Console.ReadLine());
//        }

//        foreach (int yas in yaslar)
//        {
//            string kategori;

//            if (yas >= 0 && yas <= 12)
//            {
//                kategori = "Çocuk";
//            }
//            else if (yas >= 13 && yas <= 19)
//            {
//                kategori = "Genç";
//            }
//            else if (yas >= 20 && yas <= 64)
//            {
//                kategori = "Yetişkin";
//            }
//            else
//            {
//                kategori = "Yaşlı";
//            }

//            Console.WriteLine($"Yaş: {yas}, Kategori: {kategori}");
//        }
//    }
//}

//soru4

//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Dizi elemanlarını boşluk ile ayırarak giriniz: ");
//        int[] dizi = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

//        HashSet<int> benzersizElemanlar = new HashSet<int>();
//        HashSet<int> tekrarEdenElemanlar = new HashSet<int>();

//        foreach (int eleman in dizi)
//        {
//            if (!benzersizElemanlar.Add(eleman))
//            {
//                tekrarEdenElemanlar.Add(eleman);
//            }
//        }

//        Console.WriteLine("Tekrar eden elemanlar: " + (tekrarEdenElemanlar.Count > 0 ? string.Join(", ", tekrarEdenElemanlar) : "Yok"));
//    }
//}

//soru5

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Kelime dizisini boşluk ile ayırarak giriniz: ");
//        string input = Console.ReadLine();

//        string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

//        if (words.Length == 0)
//        {
//            Console.WriteLine("Hiç kelime girilmedi.");
//            return;
//        }

//        string longestWord = words[0];
//        string shortestWord = words[0];

//        foreach (string word in words)
//        {
//            if (word.Length > longestWord.Length)
//                longestWord = word;

//            if (word.Length < shortestWord.Length)
//                shortestWord = word;
//        }

//        Console.WriteLine("En uzun kelime: " + longestWord);
//        Console.WriteLine("En kısa kelime: " + shortestWord);
//    }
//}

//soru6

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Bir cümle giriniz: ");
//        string input = Console.ReadLine();
//        string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

//        Array.Sort(words);

//        Console.WriteLine("Alfabetik sıralanmış kelimeler:");
//        foreach (string word in words)
//        {
//            Console.WriteLine(word);
//        }
//    }
//}

//soru7
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        List<string> words = new List<string>();
//        Console.WriteLine("Bir kelime giriniz (3 adet): ");
//        for (int i = 0; i < 3; i++)
//        {
//            string word = Console.ReadLine();
//            words.Add(word); 
//        }

//        Console.WriteLine("Başka bir kelime giriniz: ");
//        words.Add(Console.ReadLine());

//        Console.WriteLine("Başka bir kelime daha giriniz: ");
//        words.Add(Console.ReadLine());

//        Console.WriteLine("\nGirdiğiniz kelimeler:");
//        foreach (string word in words)
//        {
//            Console.WriteLine(word);
//        }
//    }
//}

//soru8

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        List<string> kelimeler = new List<string>();
//        string giris;

//        Console.WriteLine("Kelime girişi yapın (çıkmak için 'exit' yazın):");

//        while (true)
//        {
//            Console.Write("Kelime: ");
//            giris = Console.ReadLine();

//            if (giris.ToLower() == "exit")
//                break;

//            kelimeler.Add(giris);
//        }

//        Console.WriteLine("\nTersten yazdırılmış kelimeler:");

//        for (int i = kelimeler.Count - 1; i >= 0; i--)
//        {
//            char[] tersKelime = kelimeler[i].ToCharArray();
//            Array.Reverse(tersKelime);
//            Console.WriteLine(new string(tersKelime));
//        }
//    }
//}

//soru9

//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> sayilar = new List<int>();
//        string giris;

//        Console.WriteLine("Rastgele sayılar girin (çıkmak için 'exit' yazın):");

//        while (true)
//        {
//            Console.Write("Sayı: ");
//            giris = Console.ReadLine();

//            if (giris.ToLower() == "exit")
//                break;

//            if (int.TryParse(giris, out int sayi))
//            {
//                sayilar.Add(sayi);
//            }
//            else
//            {
//                Console.WriteLine("Lütfen geçerli bir sayı girin.");
//            }
//        }

//        if (sayilar.Count > 0)
//        {
//            double ortalama = sayilar.Average();
//            sayilar.Sort();

//            Console.WriteLine("\nGirilen sayıların ortalaması: " + ortalama);
//            Console.WriteLine("Küçükten büyüğe sıralı liste: " + string.Join(", ", sayilar));
//        }
//        else
//        {
//            Console.WriteLine("Hiç sayı girilmedi.");
//        }
//    }
//}

//soru10

//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> sayilar = new List<int>();
//        string giris;

//        Console.WriteLine("Rastgele sayılar girin (çıkmak için 'exit' yazın):");

//        while (true)
//        {
//            Console.Write("Sayı: ");
//            giris = Console.ReadLine();

//            if (giris.ToLower() == "exit")
//                break;

//            if (int.TryParse(giris, out int sayi))
//            {
//                sayilar.Add(sayi);
//            }
//            else
//            {
//                Console.WriteLine("Lütfen geçerli bir sayı girin.");
//            }
//        }

//        sayilar.RemoveAll(sayi => sayi < 10);

//        if (sayilar.Count > 0)
//        {
//            double ortalama = sayilar.Average();
//            sayilar.Sort();

//            Console.WriteLine("\nGirilen sayıların ortalaması (10'dan büyük veya eşit olanlar): " + ortalama);
//            Console.WriteLine("Küçükten büyüğe sıralı liste (10'dan büyük veya eşit olanlar): " + string.Join(", ", sayilar));
//        }
//        else
//        {
//            Console.WriteLine("Hiç 10 veya daha büyük sayı girilmedi.");
//        }
//    }
//}

//soru11

//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> notlar = new List<int>();
//        string giris;

//        Console.WriteLine("Öğrenci notlarını girin (çıkmak için 'exit' yazın):");

//        while (true)
//        {
//            Console.Write("Not: ");
//            giris = Console.ReadLine();

//            if (giris.ToLower() == "exit")
//                break;

//            if (int.TryParse(giris, out int notDegeri))
//            {
//                notlar.Add(notDegeri);
//            }
//            else
//            {
//                Console.WriteLine("Lütfen geçerli bir not girin.");
//            }
//        }

//        for (int i = 0; i < notlar.Count; i++)
//        {
//            if (notlar[i] < 50)
//            {
//                notlar[i] = 50;
//            }
//        }

//        Console.WriteLine("\nGüncellenmiş notlar: " + string.Join(", ", notlar));
//    }
//}
