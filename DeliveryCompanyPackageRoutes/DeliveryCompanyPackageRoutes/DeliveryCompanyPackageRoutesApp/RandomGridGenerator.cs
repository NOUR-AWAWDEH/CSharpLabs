using System;
using System.Collections.Generic;
using System;
using System.Security.Cryptography;

namespace DeliveryCompanyPackageRoutesApp
{
    public class RandomGridGenerator
    {
        public int[,] GenerateRandomGrid(int nodeLength)
        {
            // Initialize the grid
            int[,] grid = new int[nodeLength, nodeLength];
         
            // Use Guid to generate random numbers
            for (int i = 0; i < nodeLength; i++)
            {
                for (int j = 0; j < nodeLength; j++)
                {
                    byte[] guidBytes = Guid.NewGuid().ToByteArray();
                    grid[i,j] = guidBytes[0] & 1; // Generates either 0 or 1
                }
            }

            return grid;
        }

        
    }
}
