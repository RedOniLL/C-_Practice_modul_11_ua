using System;

namespace C__Practice_modul_11_ua
{
    public class Film : IDisposable
    {
        public string Title { get; set; }
        public string Studio { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; }
        public int Year { get; set; }

        public Film()
        {
        }

        ~Film()
        {
            Console.WriteLine($"Destructor called for film: {Title}");
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Studio: {Studio}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Duration: {Duration} minutes");
            Console.WriteLine($"Year: {Year}");
        }

        public void Dispose()
        {
            Console.WriteLine($"Destructor called for film: {Title}");
        }
    }
}
