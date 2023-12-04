using System.Collections.Immutable;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;


var linesRead = File.ReadLines("Input.txt");

//Gives the total number of cards
int numberOfLines = File.ReadAllLines("Input.txt").Length;

int total = 0;  //Sum of Cards
int cardNumber = 1; //Which Card Number are we on
List<int> cardCount = new List<int>(Enumerable.Repeat(1, numberOfLines)); //intialize an array of the number of cards starting with 0

foreach (var lineRead in linesRead)
{
    List<string> cardNumbers = ParseCard(lineRead);  //parses the line
    List<int> winningNumbers = ParseNumbers(cardNumbers[0]); //parses the winning numbers
    List<int> scratchNumbers = ParseNumbers(cardNumbers[1]); //parses the scratch numbers
                                                             //int cardTotal = 0;

    var weGotWinners = winningNumbers.Intersect(scratchNumbers); //finds combos

    int winnerCount = weGotWinners.Count();  //count of winners on that ticket
    Console.WriteLine("Card Number {0} has {1} winners", cardNumber, winnerCount);
    if (winnerCount == 0)  // there were no winners
    {

    }
    else  //we had combos
    {
        var numberOfCards = cardCount[cardNumber - 1];
        for (var j = 0; j < cardCount[cardNumber - 1]; j++)
        {  //we're inside the first winning card

            for (int winners = 0; winners < winnerCount; winners++)  //we look at the number of winners and add 1 to each
            {

                //Console.WriteLine("Increasing card Number {0} by 1", cardNumber);
                cardCount[cardNumber + winners] = cardCount[cardNumber + winners] + 1;  // card minus 1 because of 0 index
                

            }
        }
    }

    // for(var c = 0; 0 < cardCount.Count(); c++)
    // {
    //     Console.WriteLine("We have {0} of card number {1}", cardCount[c], c);
        
    // }

    cardNumber++;
    total = cardCount.Sum();
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