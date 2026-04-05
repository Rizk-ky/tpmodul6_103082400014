using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" TEST NORMAL ");

        SayaTubeVideo video1 = new SayaTubeVideo("Tutorial Design By Contract - Muhammad Rizky Ramadhan");
        video1.IncreasePlayCount(5000);
        video1.PrintVideoDetails();

        Console.WriteLine();

        Console.WriteLine(" TEST JUDUL NULL ");
        try
        {
            SayaTubeVideo video2 = new SayaTubeVideo(null);
            video2.PrintVideoDetails();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Terjadi error: " + ex.Message);
        }

        Console.WriteLine();

        Console.WriteLine(" TEST JUDUL TERLALU PANJANG ");
        try
        {
            SayaTubeVideo video3 = new SayaTubeVideo("Ini adalah judul video yang sangat sangat sangat sangat sangat sangat sangat sangat sangat sangat panjang");
            video3.PrintVideoDetails();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Terjadi error: " + ex.Message);
        }

        Console.WriteLine();

        Console.WriteLine(" TEST PLAYCOUNT TERLALU BESAR ");
        try
        {
            SayaTubeVideo video4 = new SayaTubeVideo("Tutorial C# Dasar");
            video4.IncreasePlayCount(20000000);
            video4.PrintVideoDetails();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Terjadi error: " + ex.Message);
        }

        Console.WriteLine();

        Console.WriteLine(" TEST OVERFLOW ");
        try
        {
            SayaTubeVideo video5 = new SayaTubeVideo("Tutorial Overflow C#");

            for (int i = 0; i < 220; i++)
            {
                video5.IncreasePlayCount(10000000);
            }

            video5.PrintVideoDetails();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Terjadi error: " + ex.Message);
        }

        Console.WriteLine();
        Console.WriteLine("Program selesai");
    }
}