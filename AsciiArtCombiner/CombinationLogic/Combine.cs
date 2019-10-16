using System;
using System.Collections.Generic;

namespace CombinationLogic
{
    public class Combine
    {
        public static Char[][] CombineFiles(Char[][] file1, Char[][] file2)
        {

            for (int i = 0; i<file1.Length; i++)
            {
                for(int j = 0; j<file1[0].Length; j++)
                {
                    if(file2[i][j] != ' ')
                    {
                        file1[i][j] = file2[i][j];
                    }
                }
            }

            return file1;
        }
    }
}
