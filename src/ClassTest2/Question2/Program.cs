
using Question2;

Palindrome palindrome = new Palindrome();

string text = "hi man";

var flag = palindrome.IsPalindrome(text);

if (flag)
{
    Console.WriteLine(text + " is palindrome");
}
else
{
    Console.WriteLine(text + " is not palindrome");
}

