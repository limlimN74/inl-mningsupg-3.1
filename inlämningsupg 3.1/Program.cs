using System;

namespace Inlämningsupgift_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hur gammal är du?");
            int år = int.Parse(Console.ReadLine());

            if (år >= 16 && år <= 19)
            {
                Console.WriteLine("Du får delta i tävlingen.");
            }
            else if (år < 16)
            {
                Console.WriteLine("Du är för ung för att delta i tävlingen.");
            }
            else
            {
                Console.WriteLine("Du är för gammal för att delta i tävlingen.");
            }
        }
    }
}