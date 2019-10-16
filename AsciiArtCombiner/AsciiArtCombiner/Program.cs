using AsciiArtCombiner.Services;
using System;
using System.Collections.Generic;

namespace AsciiArtCombiner
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length < 2)
            {
                //throw new System.ArgumentException("Too little Arguments provided");
                Console.WriteLine("Too little Arguments provided");
                return; 
            }

            ReadFile rf = new ReadFile();


            Char[][] result = rf.Read(args[0]);
            if (result == null) return;

            int counter = 1;
            while (counter < args.Length)
            {
                Char[][] newFile = rf.Read(args[counter]);
                if (newFile == null ) return;
                if (result.Length != newFile.Length)
                {
                    Console.WriteLine(result.Length + " " + newFile.Length);
                    Console.WriteLine("Height not fitting");
                    return;
                }

                result = CombinationLogic.Combine.CombineFiles(result, newFile);
                counter++;
            }

            rf.PrintCharArray(result);
            Console.ReadLine();
        }
    }
}
