using System;

namespace Method10
{
    class Program
    {
        // Main programının görevi kullanıcında veri almak, bilgiye dönüştürüp çıktı sağlamaktır...
        static void Main(string[] args)
        {
            Console.WriteLine("4 işlem örneği!");

            float sayi1, sayi2 = 0, sonuc;
            int TekrarN = 0;
            char islem = '+';

            Console.WriteLine("Kaç Adet Sayı Gireceksiniz");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{TekrarN + 1}. Sayıyı Giriniz");

            float islemSonucu = (float)Convert.ToDouble(Console.ReadLine());
            TekrarN++;
            islemSonucu = Islem(islem, islemSonucu, sayi2);

            do
            {
                Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
                islem = Convert.ToChar(Console.ReadLine());

                Console.WriteLine($"{TekrarN + 1}.Sayıyı Giriniz");
                sayi2 = (float)Convert.ToDouble(Console.ReadLine());
                TekrarN++;
                islemSonucu = Islem(islem, islemSonucu, sayi2);

            } while (n > TekrarN);


            Console.Write($"İşlem Sonucunuz = {islemSonucu}");

            Console.ReadKey();
        }

        // todo : bu işlemi n adet sayı için yapan metodu yazınız.. Perşembe gününe kadar gönderiniz...

        // todo:  ascii table nedir. Neden 255 karakter vardır.. araştırınız...Ve Bu programdaki gibi txt dosyasına açıklamasını yazınız...
        private static float Islem(char islem, float sayi1, float sayi2)
        {
            switch (islem)
            {
                case '+':
                    //sonuc = sayi1 + sayi2;
                    sayi1 += sayi2;
                    break;
                case '-':
                    sayi1 -= sayi2;
                    break;
                case '*':
                    sayi1 *= sayi2;
                    break;
                case '/':
                    sayi1 /= sayi2;
                    break;
            }
            return sayi1;
        }
    }
}