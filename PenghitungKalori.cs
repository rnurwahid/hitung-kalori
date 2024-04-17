//20. Menghitung Kalori berdasarkan aktiviitas
using System;

namespace PenghitungKalori{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("===Menghitung Kalori===");
            Console.Write("Masukkan berat badan Anda (kg): ");
            double beratBadan = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan jenis aktivitas (berjalan, berlari, bersepeda, berenang): ");
            string aktivitas = Console.ReadLine().ToLower();

            Console.Write("Masukkan durasi aktivitas (menit): ");
            double durasi = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan intensitas aktivitas (rendah, sedang, tinggi): ");
            string intensitas = Console.ReadLine().ToLower();

            // Definisikan nilai MET (Metabolic Equivalent of Task) untuk berbagai aktivitas
            double met = 0.0;
            switch (aktivitas){
                case "berjalan":
                    met = intensitas switch{
                        "rendah" => 2.0,
                        "sedang" => 2.8,
                        "tinggi" => 3.5,
                        _ => 0.0
                    };
                    break;
                case "berlari":
                    met = intensitas switch{
                        "rendah" => 6.0,
                        "sedang" => 8.3,
                        "tinggi" => 11.0,
                        _ => 0.0
                    };
                    break;
                case "bersepeda":
                    met = intensitas switch{
                        "rendah" => 3.5,
                        "sedang" => 5.8,
                        "tinggi" => 7.5,
                        _ => 0.0
                    };
                    break;
                case "berenang":
                    met = intensitas switch{
                        "rendah" => 4.5,
                        "sedang" => 5.8,
                        "tinggi" => 7.0,
                        _ => 0.0
                    };
                    break;
                default:
                    Console.WriteLine("Aktivitas atau intensitas tidak valid.");
                    return;
            }

            double kaloriTerbakar = met * beratBadan * (durasi / 60);

            Console.WriteLine($"Perkiraan kalori yang terbakar selama {durasi} menit {aktivitas} dengan intensitas {intensitas}: {kaloriTerbakar:F2} kalori");
        }
    }
}