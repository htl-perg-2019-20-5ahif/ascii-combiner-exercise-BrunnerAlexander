using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AsciiArtCombiner.Services
{
    public class ReadFile
    {
        public char[][] Read(string file1)
        {
            //Read from File
            string input;
            try
            {
                input = System.IO.File.ReadAllText("TestData/" + file1);
            }catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            var text = input.Replace("\r","").Split('\n');
            var controlLenght = text[0].Length;

            //Initialize Char[][]
            Char[][] ar = new char[text.Length][];
            for (int i = 0; i < text.Length; i++)
            {
                ar[i] = new char[text[i].Length];
            }

            //Write to char array
            for (int i = 0; i < text.Length; i++)
            {
                if(text[i].Length != controlLenght)
                {
                    Console.WriteLine(text[i].Length + " " + controlLenght);
                    Console.WriteLine("Line lenght not fitting");
                    return null;
                }

                ar[i] = text[i].ToCharArray();
            }

            return ar;
        }

        public void PrintCharArray(Char[][] ar)
        {
            String[] strAr = new string[ar.Length];

            for (int i=0; i < ar.Length; i++)
            {
                strAr[i] = new string(ar[i]);
            }
            for (int i=0; i < strAr.Length; i++)
            {
                Console.WriteLine(strAr[i]);
            }
        }
    }
}
