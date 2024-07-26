class Program
{
    static void Main(string[] args)
    {
        // Test case 1: Positive number with digits in ascending order
        int result1 = Kata.DecimalSorting(12345);
        Console.WriteLine(result1);  // Output: 12345

        // Test case 2: Positive number with digits in descending order
        int result2 = Kata.DecimalSorting(987654321);
        Console.WriteLine(result2);  // Output: 123456789

        // Test case 3: Positive number with repeated digits
        int result3 = Kata.DecimalSorting(543535);
        Console.WriteLine(result3);  // Output: 333455
      
        // Test case 4: Zero
        int result5 = Kata.DecimalSorting(0);
        Console.WriteLine(result5);  // Output: 0
    }
}


public static class Kata
{
    public static int DecimalSorting(int num)
    {
        if (num <= 0) return 0;
        
        string strNumber = Int32ToString(num);
        char[] charNumber = StringToCharArray(strNumber);
        int[] digitArray = CharToIntArray(charNumber);
        int[] sortedArray = BubbleSort(digitArray);
        int result = ArrayToInt(sortedArray);
        
        return result;
    }

    private static int[] CharToIntArray(char[] chars)
    {
        int length = chars.Length;
        int[] digitArray = new int[length];

        for (int i = 0; i < length; i++)
        {
            digitArray[i] = chars[i] - '0';
        }

        return digitArray;
    }

    private static void Swap(int[] arr, int index1, int index2)
    {
        int temp = arr[index1];
        arr[index1] = arr[index2];
        arr[index2] = temp;
    }

    private static int[] BubbleSort(int[] arr)
    {
        int length = arr.Length;

        for (int i = 0; i < length - 1; i++)
        {
            for (int j = 0; j < length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    Swap(arr, j, j + 1);
                }
            }
        }

        return arr;
    }

    private static int ArrayToInt(int[] arr)
    {
        int result = 0;
        int length = arr.Length;

        for (int i = 0; i < length; i++)
        {
            result = result * 10 + arr[i];
        }

        return result;
    }

    private static char[] StringToCharArray(string str)
    {   
        int length = LengthOfString(str);
        char[] chars = new char[length];

        for(int i = 0 ; i < length ; i++)
        {
            chars[i] = str[i];
        }
        return chars;
    }

    private static string Int32ToString(int num)
    {
        if (num == 0)
        {
            return "0";
        }

        bool isNegative = false;
        
        if (num < 0)
        {
            isNegative = true;
            num = -num;
        }

        string result = "";

        while (num > 0)
        {
            int digit = num % 10;
            char digitChar = (char)('0' + digit);
            result = digitChar + result;
            num /= 10;
        }

        if (isNegative)
        {
            result = "-" + result;
        }

        return result;
    }

    private static int LengthOfString(string str)
    {
        int strLength = 0;
        foreach (var c in str)
        {
            strLength++;
        }
        return strLength;
    }
}
