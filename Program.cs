// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;
using testSpilberg;
Console.WriteLine("give an input file:");
Console.WriteLine("(default file will be input.txt)");
string filePath = Console.ReadLine();

if (filePath == String.Empty)
{
    filePath = "input.txt";
}

Console.Clear();
Console.WriteLine("what length should the full words be?");

string inputLength = Console.ReadLine();
int length;

if (inputLength == String.Empty)
{
    length = 6;
}
else
{
    length = Convert.ToInt32(inputLength);
}

using (StreamReader file = new(filePath))
{
    string ln;
    WordList wordList = new();
    List<string> parts = new();

    while ((ln = file.ReadLine()) != null)
    {
        if (ln.Length == length)
        {
            Word word = new Word();
            word.FullWord = ln;
            if (!wordList.words.Contains(word))
                wordList.words.Add(word);
        }
        else if (ln.Length < length && !parts.Contains(ln))
        {
            parts.Add(ln);
        }
    }


    Console.WriteLine("program is checking for possible combinations.");
    foreach (Word item in wordList.words)
    {
        item.FindWordCombinations(parts);
    }

    wordList.OrderList();
    Console.WriteLine("Program has finished, these are the found words in the input file with combinations.");
    int counter = 0;
    Word lastWord = new Word();
    foreach (var word in wordList.words)
    {


        if (word.Word1 == null || word.Word2 == null)
        {
            return;
        }
        else if (word.Word1 == lastWord.Word1)
        {
            
        }
        else
        {
            lastWord = word;
            Console.Write(word.FullWord + " : " + word.Word1 + " + " + word.Word2);
            counter++;
            if (counter == 1)
            {
                counter = 0;
                Console.WriteLine();
            }
        }
    }
}