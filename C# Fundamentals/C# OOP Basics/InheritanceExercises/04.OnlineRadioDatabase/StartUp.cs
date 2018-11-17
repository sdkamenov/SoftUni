using _04.OnlineRadioDatabase.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.OnlineRadioDatabase
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Song> songs = new List<Song>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    if (input.Length != 3)
                    {
                        throw new InvalidSongException();
                    }

                    ParseSong(songs, input);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            long totalSeconds = songs.Sum(m => m.Minutes * 60) + songs.Sum(s => s.Seconds);
            TimeSpan ts = TimeSpan.FromSeconds(totalSeconds);
            Console.WriteLine($"Songs added: {songs.Count}");
            Console.WriteLine($"Playlist length: {ts.Hours}h {ts.Minutes}m {ts.Seconds}s");
        }

        private static void ParseSong(List<Song> songs, string[] input)
        {
            string[] time = input[2].Split(":", StringSplitOptions.RemoveEmptyEntries);
            int minutes = int.Parse(time[0]);
            int seconds = int.Parse(time[1]);

            try
            {
                Song song = new Song(input[0], input[1], minutes, seconds);
                songs.Add(song);
                Console.WriteLine("Song added.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
