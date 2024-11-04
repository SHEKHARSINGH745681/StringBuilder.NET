using System;

class PalindromeCheck
{
    public static bool IsPalindrome(string word)
    {
        //word ko lower case main kiya hai
        word = word.ToLower();
        return word == new string(word.Reverse().ToArray());
    }

    static void Main()
    {
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();
        Console.WriteLine(IsPalindrome(word) ? "It's a palindrome." : "Not a palindrome.");
    }
}
