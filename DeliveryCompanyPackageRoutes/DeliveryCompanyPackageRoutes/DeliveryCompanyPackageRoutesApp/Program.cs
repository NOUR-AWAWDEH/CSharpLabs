namespace DeliveryCompanyPackageRoutesApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            RandomGridGenerator generator = new RandomGridGenerator();
            int[][] grid = generator.GenerateRandomGrid(5);
            
            for(int i = 0 ;i < grid.Length ; i++) 
            {
                for (int j = 0 ;j < grid.Length ; j++) 
                {
                    Console.Write(grid[i][j]);
                    
                }
                Console.WriteLine();
            }

        }
    }
}


/*

My Approach:

done    => Initialize the grid of intersection(the representation of the city).
        => use Dijkstra's algorithm to find the shortest path.    
        => i think while implementing the Dijkstra's algorithm, we have to update for each neighboring intersection.
        => Return the shortest time or indicate if the destination is unreachable.

 */