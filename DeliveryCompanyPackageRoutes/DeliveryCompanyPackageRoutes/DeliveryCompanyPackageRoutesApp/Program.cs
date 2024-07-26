namespace DeliveryCompanyPackageRoutesApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            RandomGridGenerator generator = new RandomGridGenerator();
            int[,] grid = generator.GenerateRandomGrid(5);

            Console.WriteLine("The City Grid: ");
            Console.WriteLine("{");
            for (int i = 0 ;i < grid.GetLength(0); i++) 
            {
                Console.Write(" { ");
                for (int j = 0 ;j < grid.GetLength(1); j++) 
                {
                    
                    Console.Write( grid[i,j]);
                    if (j < grid.GetLength(0) -1)
                        Console.Write( "," );
                    
                }
                
                Console.Write(" }");
                if(i < grid.GetLength(1) - 1)
                    Console.Write(",");
                Console.WriteLine();
            }
            Console.WriteLine("};\n");

            // Coordinates of the delivery depot.
            int depotX = 0, depotY = 0;

            // Coordinates of the delivery destination.
            int destX = 3, destY = 3;

            // Finding the shortest delivery time.
            int shortestTime = PackageDelivery.FindShortestDeliveryTime(grid, depotX, depotY, destX, destY);

            // Printing the shortest delivery time.
            Console.WriteLine("Shortest Delivery Time: " + shortestTime);

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