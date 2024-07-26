using System;

namespace _1_AsteriskTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baseSize = 10;
            char asterisk = '*';
            char spaceChar = ' ';
            


            for (int row = 0; row < baseSize; row++)
            {
                for (int colSpace = 0; colSpace < (baseSize - row); colSpace++)
                {
                    Console.Write(spaceChar);
                }

                for (int colAsterisk = 0; colAsterisk < (( row * 2 ) - 1); colAsterisk++)
                {
                    Console.Write(asterisk);
                }
                Console.WriteLine();
            }
        }
    }
}
/*

         *
        ***
       *****
      *******
     *********
    ***********
   *************
  ***************
 *****************
 
*/