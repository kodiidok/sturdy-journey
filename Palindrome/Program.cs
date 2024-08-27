namespace Palindrome;

class Program
{
    /// <summary>
    /// Determines whether the given input string, after removing specified trash symbols, is a palindrome.
    /// A palindrome is a word, phrase, number, or other sequence of characters that reads the same forward and backward, 
    /// ignoring any trash symbols specified.
    /// </summary>
    /// <param name="inputString">The string to be checked for palindrome properties.</param>
    /// <param name="trashSymbol">A string containing characters that should be ignored when checking for a palindrome.</param>
    /// <returns>
    /// A boolean value indicating whether the processed string (with trash symbols removed) is a palindrome.
    /// Returns true if the input string is a palindrome; otherwise, returns false.
    /// </returns>
    /// <remarks>
    /// The method uses a two-pointer approach to compare characters from the beginning and end of the string, 
    /// moving inward while skipping any characters that are present in the trash symbols string.
    /// If at any point the characters do not match, the method concludes that the string is not a palindrome.
    /// </remarks>
    static bool CheckPalindrome(string inputString, string trashSymbol)
    {
        // Two pointers to check for palindrome
        int left = 0;
        int right = inputString.Length - 1;

        while (left < right)
        {
            // Move left pointer to the next valid character
            while (left < right && trashSymbol.Contains(inputString[left]))
            {
                left++;
            }

            // Move right pointer to the previous valid character
            while (left < right && trashSymbol.Contains(inputString[right]))
            {
                right--;
            }

            // Check if the current characters are equal
            if (left < right && inputString[left] != inputString[right])
            {
                Console.WriteLine("Is Palindrome: False");
                return false;
            }

            // Move both pointers
            left++;
            right--;
        }

        Console.WriteLine("Is Palindrome: True");

        return true;
    }


    static void Main(string[] args)
    {
        string inputString1 = "a@b!!b$a";
        string trashSymbolsString1 = "!@$";

        string inputString2 = "?Aa#c";
        string trashSymbolsString2 = "#?";

        CheckPalindrome(inputString1, trashSymbolsString1);
        CheckPalindrome(inputString2, trashSymbolsString2);
    }
}