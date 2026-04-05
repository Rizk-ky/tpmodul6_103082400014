using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        if (title == null)
        {
            throw new ArgumentNullException("title", "Judul video tidak boleh null.");
        }

        if (title.Length > 100)
        {
            throw new ArgumentException("Judul video tidak boleh lebih dari 100 karakter.");
        }

        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        if (count > 10000000)
        {
            throw new ArgumentException("Penambahan play count maksimal 10.000.000 per panggilan.");
        }

        if (count < 0)
        {
            throw new ArgumentException("Penambahan play count tidak boleh negatif.");
        }

        checked
        {
            playCount += count;
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("ID Video    : " + id);
        Console.WriteLine("Judul Video : " + title);
        Console.WriteLine("Play Count  : " + playCount);
    }
}