using System;

namespace C__Practice_modul_11_ua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Film film = new Film
                    {
                        Title = "Inception",
                        Studio = "Warner Bros.",
                        Genre = "Sci-Fi",
                        Duration = 148,
                        Year = 2010
                    };

                    film.DisplayDetails();
                    film.Dispose();
                    break;
                case 2:
                    Performance performance = new Performance
                    {
                        Title = "Hamlet",
                        Theater = "Globe Theatre",
                        Genre = "Tragedy",
                        Duration = 120
                    };

                    performance.Actors.Add("John Doe");
                    performance.Actors.Add("Jane Smith");

                    performance.DisplayDetails();

                    performance.Dispose();
                    break;
            }

            Console.ReadLine();
        }
    }
}
