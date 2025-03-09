using System;
using tpmodul4_103022300149;

class Program
{
    static void Main()
    {
        KodePos kodePos = new KodePos();
        Console.Write("Masukkan kelurahan: ");
        string kelurahan = Console.ReadLine();

        string kode = kodePos.GetKodePos(kelurahan);
        if (kode != null)
        {
            Console.WriteLine($"Kode Pos {kelurahan}: {kode}");
        }
        else
        {
            Console.WriteLine("Kelurahan tidak ditemukan.");
        }
    }
}