using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

var linesRead = File.ReadLines("Input.txt");
//Math.Pow(base, power)List<string> 

int total = 0;

foreach (var lineRead in linesRead)
{
    List<string> cardNumbers = ParseCard(lineRead);
    List<int> winningNumbers = ParseNumbers(cardNumbers[0]);
    List<int> scratchNumbers = ParseNumbers(cardNumbers[1]);
    int cardTotal = 0;


    var weGotWinners = winningNumbers.Intersect(scratchNumbers);

    if (weGotWinners.Count() == 0)
    {
        cardTotal = 0;
    }
    else
    {
        cardTotal = (int)Math.Pow(2, weGotWinners.Count() - 1);
    }

    total = total + cardTotal;
}

Console.WriteLine(total);
List<string> ParseCard(string lineOfCard)
{
    List<string> cardText = lineOfCard.Split(": ").ToList<string>();  //splits card game and numbers
    List<string> cardSplit = cardText[1].Split(" | ").ToList<string>();
    return cardSplit;
}

List<int> ParseNumbers(string input)
{
    List<int> result = new List<int>();

    string[] numberStrings = input.Split(' ');

    foreach (string numberString in numberStrings)
    {
        if (int.TryParse(numberString, out int number))
        {
            result.Add(number);
        }

    }

    return result;
}

