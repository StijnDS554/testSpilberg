// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;

using (StreamReader file = new StreamReader("input.txt"))
{
    string ln;
    List<string> lines = new List<string>();
    List<string> foundWords = new List<string>();
    while ((ln = file.ReadLine()) != null)
    {
        if (!lines.Contains(ln))
        lines.Add(ln);
    }
    file.Close();
    Console.WriteLine("program is checking for possible combinations.");
    for (int i = 0; i < lines.Count; i++)
    {
        string line = lines[i];
        for (int y = 0; y < lines.Count; y++)
        {
            string line2 = lines[y];
            string currentWord = line + line2;
            if (currentWord.Length == 6 && !foundWords.Contains(currentWord))
            {
                if (lines.Contains(currentWord))
                {
                    foundWords.Add(currentWord);

                }
            }
        }

    }
    Console.WriteLine("Program has finished, these are the found words in the input file with combinations.");
    int counter = 0;
    foreach (string word in foundWords)
    {
        Console.Write(word + " ");
        counter++;
        if (counter == 10)
        {
            counter = 0;
            Console.WriteLine();
        }
    }
}