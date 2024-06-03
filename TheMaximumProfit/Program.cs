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
        2. Find the largest value, but ensure that your chosen value that has higher index than the index of that value.
            2.2 return 0 if this requirement is false.  
            2.3 return the MaxProfit.   
    
     */

    public class Program
    {
        static void Main(string[] args)
        {
            List<int> prices = [7, 1, 5, 3, 6, 4];


            Program program = new Program();
            int maxProfit = program.MaxProfit(prices);

            Console.ReadLine();
        }

        public int MaxProfit(List<int> prices) 
        {
            int minimumPrice = prices[prices.Count - 1];
            int maximumPrice = prices[prices.Count - 1];

            for (int index = 0 ; index < prices.Count - 1 ; index++)
            {
                if (minimumPrice > prices[index])
                {
                    maximumPrice = minimumPrice;
                    minimumPrice = prices[index];    
                }

                if(maximumPrice < prices[index]) 
                {
                    maximumPrice = prices[index];
                }
                
            }

            int maxProfit = maximumPrice - minimumPrice;
            PrintResualt(maxProfit ,minimumPrice ,maximumPrice );
            return maxProfit;
        }

        public void PrintResualt(int maxProfit,int minimumPrice, int maximumPrice) 
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
