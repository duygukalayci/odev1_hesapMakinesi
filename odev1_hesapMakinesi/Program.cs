namespace odev1_hesapMakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hesap Makinesi: ");
            Console.WriteLine();

            Console.Write("1.sayı: ");
            double sayi1=Convert.ToDouble(Console.ReadLine());

            Console.Write("2.sayı: ");
            double sayi2=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("yapacağınız işlemi seçin: +,-,*,/");
            char islem=Convert.ToChar(Console.ReadLine());

            double sonuc = 0;

            if( islem =='+')
            {
                sonuc = sayi1 + sayi2;
            }

            else if(islem=='-')
            {
                sonuc = sayi1 - sayi2;
            }
            else if(islem=='*')
            {
                sonuc= sayi1 * sayi2;
            }
            else if(islem=='/')
            {
                sonuc=sayi1 / sayi2;
            }
            else
            {
                Console.WriteLine("geçersiz işlem!!!!!!!");
                return;
            }

            Console.WriteLine($"Sonuç:  {sonuc}");



            Console.Read();
        }
    }
}
