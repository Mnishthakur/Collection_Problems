using System;
using System.Collections.Generic;

namespace Collection_Problem
{
    public class AmeliaBookReader
    {
        public static int GetChaptersYetToRead(int N, List<Tuple<int, int>> chapters, int K)
        {
            int chaptersYetToRead = 0;

            foreach (var chapter in chapters)
            {
                int startPage = chapter.Item1;
                int endPage = chapter.Item2;

                if (startPage <= K && K <= endPage)
                    break;

                chaptersYetToRead++;
            }

            return N - chaptersYetToRead;
        }

        public static void Main()
        {
            int N = 4; // Total number of chapters
            List<Tuple<int, int>> chapters = new List<Tuple<int, int>>()
        {
            Tuple.Create(1, 4),
            Tuple.Create(5, 7),
            Tuple.Create(9, 16),
            Tuple.Create(17, 26)
        };
            int K = 7; // Current reading page

            int chaptersYetToRead = GetChaptersYetToRead(N, chapters, K);
            Console.WriteLine("Number of chapters yet to read: " + chaptersYetToRead);
        }
    }

}



