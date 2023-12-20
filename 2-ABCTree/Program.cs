using System;

namespace _2_ABCTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int row = 0; row < alphabet.Length; row++)
            {
                for (int col = 0; col < (alphabet.Length - row - 1); col++)
                {
                    Console.Write(' ');
                }

                for (int k = 0; k <= row; k++)
                {
                    Console.Write(alphabet[k]);
                }

                for (int k = row - 1; k >= 0; k--)
                {
                    Console.Write(alphabet[k]);
                }

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
/*
 
                         A
                        ABA
                       ABCBA
                      ABCDCBA
                     ABCDEDCBA
                    ABCDEFEDCBA
                   ABCDEFGFEDCBA
                  ABCDEFGHGFEDCBA
                 ABCDEFGHIHGFEDCBA
                ABCDEFGHIJIHGFEDCBA
               ABCDEFGHIJKJIHGFEDCBA
              ABCDEFGHIJKLKJIHGFEDCBA
             ABCDEFGHIJKLMLKJIHGFEDCBA
            ABCDEFGHIJKLMNMLKJIHGFEDCBA
           ABCDEFGHIJKLMNONMLKJIHGFEDCBA
          ABCDEFGHIJKLMNOPONMLKJIHGFEDCBA
         ABCDEFGHIJKLMNOPQPONMLKJIHGFEDCBA
        ABCDEFGHIJKLMNOPQRQPONMLKJIHGFEDCBA
       ABCDEFGHIJKLMNOPQRSRQPONMLKJIHGFEDCBA
      ABCDEFGHIJKLMNOPQRSTSRQPONMLKJIHGFEDCBA
     ABCDEFGHIJKLMNOPQRSTUTSRQPONMLKJIHGFEDCBA
    ABCDEFGHIJKLMNOPQRSTUVUTSRQPONMLKJIHGFEDCBA
   ABCDEFGHIJKLMNOPQRSTUVWVUTSRQPONMLKJIHGFEDCBA
  ABCDEFGHIJKLMNOPQRSTUVWXWVUTSRQPONMLKJIHGFEDCBA
 ABCDEFGHIJKLMNOPQRSTUVWXYXWVUTSRQPONMLKJIHGFEDCBA
ABCDEFGHIJKLMNOPQRSTUVWXYZYXWVUTSRQPONMLKJIHGFEDCBA
 
 */