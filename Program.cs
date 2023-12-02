using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

var linesRead = File.ReadLines("Day2.txt");
int total = 0;

foreach (var lineRead in linesRead)
{
   FindAndPrintPrefix(lineRead, "red");
    FindAndPrintPrefix(lineRead, "green");
    FindAndPrintPrefix(lineRead, "blue");
    
    //total = total + ParseGame(lineRead);
}

Console.WriteLine(total);

int ParseGame(string lineOfGame)
{
    string[] gameText = lineOfGame.Split(":");
    string[] gameSplit = gameText[0].Split(" ");
    string gamePoints = gameSplit[1];
    return Int32.Parse(gamePoints);
}


int FindAndPrintPrefix(string input, string targetString)
{
    int index = 0;
    var gameNumber = ParseGame(input);
    int biggestSize = 0;
    while ((index = input.IndexOf(targetString, index)) != -1)
    {
        if (index >= 3)
        {
            string prefix = input.Substring(index - 3, 3);
            //Console.WriteLine("Found at index {0}, prefix: {1}", index, prefix);
            if (Int32.Parse(prefix) > biggestSize)
            {
                //Console.WriteLine("Game {0} wouldn't work", gameNumber);
                biggestSize = Int32.Parse(prefix);
            }
        }


        index++;
    }
    Console.WriteLine("Biggest size for game {0} {1} is {2}", gameNumber, targetString, biggestSize);

    return biggestSize;
}
/* 
Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green
Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue
Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red
Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red
Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green */
