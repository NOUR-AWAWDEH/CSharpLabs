
public class Solution
{
    private Dictionary<char, int> RomanValues = new Dictionary<char, int>
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

    public int RomanToInt(string s)
    {
        int result = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (i > 0 && RomanValues[s[i]] > RomanValues[s[i - 1]])
            {
                result += RomanValues[s[i]] - 2 * RomanValues[s[i - 1]];
            }
            else
            {
                result += RomanValues[s[i]];
            }
        }
        return result;
    }

    static void Main()
    {
        string s = "III";
        Solution solu = new Solution();

        Console.WriteLine(solu.RomanToInt(s)); // Output: 58
    }
}


//Explanation:

//Conversion Logic:
    //Loop through each character in the string.
    //Check if the current character represents a value greater than the previous character.
        //If true, it indicates a subtractive combination (e.g., IV = 4),
        //and we adjust the result by subtracting twice the previous value (since it was added once before).
    //Otherwise, just add the current value to the result.