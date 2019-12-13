using System;

namespace testScores
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] scores = new int[8];
            int input;
            for (int i = 0; i < scores.Length; ++i)
            {
                Console.WriteLine("Plese enter a test score #" + (i+1));
                input = Convert.ToInt32(Console.ReadLine());
                scores[i] = input;
            }
            RunLine();
            DisplayScores(scores);

        }
        
        public static void DisplayTotal(int[] scores)
        {
            int total = 0;
            for(int i = 0; i < scores.Length; ++i)
            {
                total = total + scores[i];
            }
            RunLine();
            Console.WriteLine(total);
        }
        public static void DisplayScores(int[]scores)
        {
            Console.WriteLine("Scores in original order");
            for (int i = 0; i < scores.Length; ++i)
            {
                Console.WriteLine("{0, 6}" , scores[i]);
            }
        }
        public static void RunLine()
        {
            Console.WriteLine("\n------------------------------------------------");
        }
    }
}
