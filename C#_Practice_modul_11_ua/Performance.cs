using System;
using System.Collections.Generic;

namespace C__Practice_modul_11_ua
{
    public class Performance : IDisposable
    {
        public string Title { get; set; }
        public string Theater { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; }
        public List<string> Actors { get; set; } = new List<string>();

        public void Dispose()
        {
            Actors.Clear();
            Console.WriteLine($"Performance '{Title}' resources have been released.");
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Theater: {Theater}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Duration: {Duration} minutes");
            Console.WriteLine("Actors: " + string.Join(", ", Actors));
        }

        ~Performance()
        {
            this.Dispose();
        }
    }
}
