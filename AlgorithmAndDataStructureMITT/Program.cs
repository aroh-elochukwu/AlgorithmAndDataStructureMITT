bool isPalindrome(string testString)
{
    StringBuilder compareString1 = new StringBuilder();
    StringBuilder compareString2 = new StringBuilder();

    for (int index = testString.Length - 1; index >= 0; index--)
    {
        compareString1.Append(testString[index]);
    }

    for (int index = 0; index < testString.Length; index++)
    {
        compareString2.Append(testString[index]);
    }

    Console.WriteLine(compareString1);
    Console.WriteLine(compareString2);

    return String.Equals(compareString1.ToString(), compareString2.ToString());


}



Console.WriteLine(isPalindrome("abab"));