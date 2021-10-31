using System;

namespace exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                    Console.WriteLine(">>> PENJUMLAHAN <<<");
                    Console.WriteLine("masukkan angka 1=");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("masukkan angka 2=");
                    int y = int.Parse(Console.ReadLine());

                    int jumlah = x + y;
                    Console.WriteLine("Hasil Penjumlahan adalah = " + jumlah);
                    
            }
            catch(FormatException e)
            // penggunaan e untuk menampilkan kalimat default sistem
            {
                Console.WriteLine (e.Message);
            }

            try 
            {
                Console.WriteLine(">>> PENGURANGAN <<<");
                Console.WriteLine("masukkan angka 1=");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("masukkan angka 2=");
                int y = int.Parse(Console.ReadLine());

                int kurang = x - y;
                Console.WriteLine("Hasil Pengurangan adalah = " + kurang);
            }

            catch (FormatException e)
            // penggunaan e untuk menampilkan kalimat default sistem
            {
                Console.WriteLine(e.Message);
            }

            try 
            {
                Console.WriteLine(">>> PERKALIAN <<<");
                Console.WriteLine("masukkan angka 1=");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("masukkan angka 2=");
                int y = int.Parse(Console.ReadLine());

                int kali = x * y;
                Console.WriteLine("Hasil Perkalian adalah = " + kali);
            }

            catch (FormatException e)
            // penggunaan e untuk menampilkan kalimat default sistem
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine(">>> PEMBAGIAN <<<");
                Console.WriteLine("masukkan angka 1=");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("masukkan angka 2=");
                int y = int.Parse(Console.ReadLine());

                int bagi = x / y;
                Console.WriteLine("Hasil Pembagian adalah = " + bagi);
            }

            catch (FormatException e)
            // penggunaan e untuk menampilkan kalimat default sistem
            {
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Tidak bisa di bagi dengan angka 0");
            }
            finally
            //blok yang ditulisakan dibawah try dan catch
            {
                Console.WriteLine("Finish");
            }
        }
    }
}
