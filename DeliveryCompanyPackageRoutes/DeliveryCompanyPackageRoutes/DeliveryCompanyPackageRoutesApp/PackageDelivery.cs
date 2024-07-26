using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryCompanyPackageRoutesApp
{
    /// <summary>
    /// The PackageDelivery class contains methods to find the shortest delivery route
    /// in a city grid while considering traffic light delays.
    /// </summary>
    public class PackageDelivery
    {
        /// <summary>
        /// Represents a point in the grid with coordinates and the time taken to reach this point.
        /// </summary>
        public class Node : IComparable<Node>
        {
            /// <summary>
            /// Gets the X coordinate of the node.
            /// </summary>
            public int X { get; }

            /// <summary>
            /// Gets the Y coordinate of the node.
            /// </summary>
            public int Y { get; }

            /// <summary>
            /// Gets the time taken to reach this node.
            /// </summary>
            public int Time { get; }

            /// <summary>
            /// Initializes a new instance of the Node class.
            /// </summary>
            /// <param name="x">The X coordinate of the node.</param>
            /// <param name="y">The Y coordinate of the node.</param>
            /// <param name="time">The time taken to reach this node.</param>
            public Node(int x, int y, int time)
            {
                X = x;
                Y = y;
                Time = time;
            }

            /// <summary>
            /// Compares this node to another node based on the time taken to reach the nodes.
            /// </summary>
            /// <param name="other">The other node to compare to.</param>
            /// <returns>An integer that indicates the relative order of the nodes being compared.</returns>
            public int CompareTo(Node other)
            {
                return Time.CompareTo(other.Time);
            }
        }

        /// <summary>
        /// Finds the shortest delivery time from the depot to the destination in the city grid.
        /// </summary>
        /// <param name="grid">The city grid represented as a 2D array where 0 indicates no traffic light and 1 indicates a traffic light.</param>
        /// <param name="depotX">The X coordinate of the delivery depot.</param>
        /// <param name="depotY">The Y coordinate of the delivery depot.</param>
        /// <param name="destX">The X coordinate of the delivery destination.</param>
        /// <param name="destY">The Y coordinate of the delivery destination.</param>
        /// <returns>The shortest delivery time from the depot to the destination or -1 if the destination is unreachable.</returns>
        public static int FindShortestDeliveryTime(int[,] grid, int depotX, int depotY, int destX, int destY)
        {
            int rows = grid.GetLength(0); // Getting the number of rows in the grid.
            int cols = grid.GetLength(1); // Getting the number of columns in the grid.

            // Possible movements (right, down, left, up).
            int[][] directions =
            [
                [0, 1],
                [1, 0],
                [0, -1],
                [-1, 0]
            ];

            // Array to store the shortest known time to reach each intersection.
            int[,] times = new int[rows, cols];

            // Initialize all times to int.MaxValue indicating initially unreachable.
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    times[i, j] = int.MaxValue;
                }
            }

            // Setting the starting point time to 0.
            times[depotX, depotY] = 0;
            // Creating a priority queue to process nodes based on the shortest time.
            var priorityQueue = new PriorityQueue<Node, int>();
            // Adding the starting node to the priority queue.
            priorityQueue.Enqueue(new Node(depotX, depotY, 0),0);

            // While there are nodes to process in the priority queue.
            while (priorityQueue.Count > 0)
            {
                // Extracting the node with the minimum time.
                Node current = priorityQueue.Dequeue();

                // If the destination is reached, return the time taken.
                if (current.X == destX && current.Y == destY)
                {
                    return current.Time;
                }

                // Explore all possible movements.
                foreach (int[] direction in directions)
                {
                    int newX = current.X + direction[0]; // Calculate new X coordinate.
                    int newY = current.Y + direction[1]; // Calculate new Y coordinate.

                    // Check if the new coordinates are within grid bounds.
                    if (newX >= 0 && newX < rows && newY >= 0 && newY < cols)
                    {
                        // Calculate the new time to reach the neighboring node.
                        int newTime = current.Time + (grid[newX,newY] == 1 ? 2 : 1);

                        // If the new time is shorter than the previously known time, update and add to the priority queue.
                        if (newTime < times[newX, newY])
                        {
                            // Update the shortest known time.
                            times[newX, newY] = newTime;

                            // Add the new node to the priority queue.
                            priorityQueue.Enqueue(new Node(newX, newY, newTime),newTime);
                        }
                    }
                }
            }

            // Return -1 if the destination is unreachable.
            return -1;
        }
    }

}
