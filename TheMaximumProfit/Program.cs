using System.Diagnostics;
using System.Numerics;

namespace TheMaximumProfit
{

    /*
        1. Given a list of integers representing the prices of a stock on different days, 
        write a C# function to find the maximum profit that can be achieved by buying and selling the stock at most once.
        Additionally, you are not allowed to short sell 
        (i.e., you must buy before you sell).
        If no profit can be made, return 0.

        Example:

        Input: [7, 1, 5, 3, 6, 4]
        Output: 5 (The maximum profit is achieved by buying at 1 and selling at 6)

        Input: [7, 6, 4, 3, 1]
        Output: 0 (In this case, no valid profit can be made)

        Our task is to implement a C# function with the following signature:

        public int MaxProfit(List<int> prices)
        Now, in addition to solving the problem, we must analyze the time complexity of the solution
        and discuss how we might optimize it further.

     */


    /*
        Soution :

        1. Find the Smallest Value.
        2. Find the largest value, but ensure that your chosen value
 that has higher index than the index of that value.
            2.2 return 0 if this requirement is false.  
            2.3 return the MaxProfit.   
    
     */


    public class Program
    {
        static void Main(string[] args)
        {
            List<int> prices = new List<int> { 10, 5, 3, 6, 1, 7};
            Program program = new Program();
            int maxProfit = program.MaxProfit(prices);
            Console.ReadLine();
        }

        public int MaxProfit(List<int> prices)
        {
            if (prices == null || prices.Count < 2)
            {
                return 0; // here you mean it Cannot make a profit with less than 2 prices which is correct 
            }

            int minPrice = prices[0]; // start from the first element of the the list 
            int maxProfit = 0;
            int currentPrice = 0;
            for (int i = 1; i < prices.Count; i++)
            {
                currentPrice = prices[i];
                maxProfit = Math.Max(maxProfit, currentPrice - minPrice);
                minPrice = Math.Min(minPrice, currentPrice);
            }

            PrintResualt(maxProfit, minPrice, currentPrice);
            return maxProfit;
        }


        private void PrintResualt(int maxProfit, int minimumPrice, int maximumPrice)
        {
            if (maxProfit != 0)
            {
                Console.WriteLine($"Output: {maxProfit} (The maximum profit is achieved by buying at {minimumPrice} and selling at {maximumPrice}");
            }
            else
            {
                Console.WriteLine($"Output: {maxProfit}(In this case, no valid profit can be made)");
            }
        }

    
    }
}


//Test Case 
/*


    Typical Case:
        Input: [7, 1, 5, 3, 6, 4]
        Expected Output: 5 (Buy at 1, Sell at 6)

    No Profit Possible:
        Input: [7, 6, 4, 3, 1]
        Expected Output: 0 (Prices are always decreasing)

    Single Day Price:
        Input: [5]
        Expected Output: 0 (Not enough prices to buy and sell)

    Two Days Price, Profit Possible:
        Input: [1, 5]
        Expected Output: 4 (Buy at 1, Sell at 5)

    Two Days Price, No Profit:
        Input: [5, 1]
        Expected Output: 0 (Price decreases, no profit)

    All Same Prices:
        Input: [3, 3, 3, 3, 3]
        Expected Output: 0 (No profit possible as prices are the same)

    Large Jump in Price:
        Input: [1, 2, 3, 4, 5, 100]
        Expected Output: 99 (Buy at 1, Sell at 100)

    Random Prices with Multiple Profits Possible:
        Input: [2, 4, 1, 7, 5, 3, 6, 4]
        Expected Output: 6 (Buy at 1, Sell at 7)

    Early Peak:
        Input: [10, 7, 5, 8, 11, 9]
        Expected Output: 6 (Buy at 5, Sell at 11)

    Late Peak:
        Input: [2, 1, 2, 0, 1]
        Expected Output: 1 (Buy at 1, Sell at 2)

 */