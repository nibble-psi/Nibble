using CommunityToolkit.Mvvm.ComponentModel;

namespace NibbleTools.ViewModels;

public class StringGeneratorViewModel : ObservableRecipient
{
    public static string GenerateRandomWord(int length)
    {
        const string chars = "abcdefghijklmnopqrstuvwxyz";
        var random = new Random();
        var word = "";
        word = new string(Enumerable.Repeat(chars, length)
                                    .Select(s => s[random.Next(s.Length)])
                                    .ToArray());
        return word;
    }

    public static string GenerateRandomSentence()
    {
        var random = new Random();
        var numWords = random.Next(10, 16);
        var sentence = "";
        for (var i = 0; i < numWords; i++)
        {
            sentence += GenerateRandomWord(random.Next(3, 8)) + " ";
        }

        sentence = char.ToUpper(sentence[0]) + sentence.Substring(1).Trim() + ".";
        return sentence;
    }

    public static string GenerateRandomParagraph()
    {
        var random = new Random();
        var numWords = random.Next(25, 40);
        var paragraph = "";
        for (var i = 0; i < numWords; i++)
        {
            paragraph += GenerateRandomWord(random.Next(3, 8)) + " ";
            if ((i + 1) % 12 == 0)
            {
                paragraph += "\n"; // Append a newline character
            }
        }

        paragraph = char.ToUpper(paragraph[0]) + paragraph.Substring(1).Trim() + ".";
        return paragraph;
    }
}