using System;

class Program
{
    static void Main(string[] args)
    {
        SayaTubeVideo video1 = new SayaTubeVideo("Tutorial Design By Contract - Muhammad Rizky Ramadhan");
        video1.IncreasePlayCount(5000);
        video1.PrintVideoDetails();
    }
}