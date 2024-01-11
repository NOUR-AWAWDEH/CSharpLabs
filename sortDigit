public static class Kata
{
    public static int DescendingOrder(int num)
    {
        if( num <= 0 ) return 0;
        char[] digits = GetDigits(num);
        BubbleSortDescending(digits);
        return ConvertToNumber(digits);
    }
    
    private static char[] StringToCharArray( string strNumber)
    {   
        char[] charStr = new char[strNumber.Length];
        for(int i = 0 ; i < strNumber.Length ; i++)
        {
            charStr[i] = strNumber[i];
        }
        return charStr;
    }
    
    private static int ToDigitValue( char digit ) 
    {
        return digit - '0' ;
    }

    private static char[] GetDigits(int num)
    {
        string strNumber = num.ToString();
        char[] digits = new char[strNumber.Length];
        for(int i = 0 ; i < strNumber.Length ; i++)
        {
            digits[i] = strNumber[i];
        }
        return digits;
    }

    private static bool IsSmaller(char a, char b)
    {
        return a < b ;
    }

    private static void Swap(char[] digits, int i, int j)
    {
        char temp = digits[i];
        digits[i] = digits[j];
        digits[j] = temp;
    }

    private static void BubbleSortDescending( char[] digits)
    {
        bool swapped;
        do
        {
            swapped = false;
            for(int i = 0 ; i < digits.Length -1 ;i++)
            {
                if(IsSmaller(digits[i], digits[ i + 1 ]))
                {
                    Swap(digits,i,i+1);
                    swapped = true;
                }
                
            }
        }while(swapped);
    }

    private static int ConvertToNumber(char[] digits)
    {
        int result = 0;
        for (int i = 0; i < digits.Length; i++)
        {
            result = result * 10 + ToDigitValue(digits[i]);
        }
        return result;
    } 
    
}
