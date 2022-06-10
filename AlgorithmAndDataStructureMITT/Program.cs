string[] wordsArray = { };
int wordsNumber;
char userChar;
char[] userCharsArray = { };

Console.WriteLine("Please input the number of words for this array");
wordsNumber = Int32.Parse(Console.ReadLine());

for (int index = 1; index <= wordsNumber; index++)
{
    Console.WriteLine($"Please enter word {index}");
    string word = Console.ReadLine();
    Array.Resize(ref wordsArray, wordsArray.Length + 1);
    wordsArray[wordsArray.Length - 1] = word;

}

Console.WriteLine("Please enter a character to compare");
userChar = Console.ReadKey().KeyChar;

foreach (string word in wordsArray)
{
    int charCount = 0;

    userCharsArray = word.ToCharArray(0, word.Length);
    for (int index = 0; index < userCharsArray.Length; index++)
    {
        if (userCharsArray[index] == userChar)
        {
            charCount++;
        }
    }
    Console.WriteLine($"charater count {charCount}, word length {userCharsArray.Length}");
    double charInWordPercentage;
  
    charInWordPercentage = charCount * 100 / userCharsArray.Length ;
    Console.WriteLine(charInWordPercentage);

    if (charInWordPercentage >= 25)
    {
        Console.WriteLine($"The letter '{userChar}' appeared in {word} {charCount} times. This letter makes up more than 25% of the total number of characters.  ");
    }
    else if (charInWordPercentage < 25)
    {
        Console.WriteLine($"The letter '{userChar}' appeared in {word} {charCount} times.");
    }

}