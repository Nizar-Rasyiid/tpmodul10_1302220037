using System;
using AljabarLibraries;
public class Program
{
    public static void Main(string[] args)
    {
        // Contoh penggunaan fungsi AkarPersamaanKuadrat dari kelas Library
        double[] akar = AljabarLibraries.Aljabar.AkarPersamaanKuadrat(new double[] { 1, -3, -10 });
        Console.WriteLine("AkarPersamaanKuadrat({1, -3, -10}): " + string.Join(", ", akar));

        // Contoh penggunaan fungsi HasilKuadrat dari kelas Library
        double[] hasil = AljabarLibraries.Aljabar.HasilKuadrat(new double[] { 2, -3 });
        Console.WriteLine("HasilKuadrat({2, -3}): " + string.Join(", ", hasil));
    }
}