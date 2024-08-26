namespace Palindrome;

class Program
{
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