using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryCompanyPackageRoutesApp
{
    public class DijkstasAlgorithm
    {
        public int[] GetShortesPath(int[][] grid) 
        {
            int[] result = new int[grid.Length];   
            return result;
        }




        public int TimeLate(int[] path) 
        {
            int time = 0;
            foreach (int i in path) 
            {
                time =+i;
            }
            return time;
        }
    }
}
