/* using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

var linesRead = File.ReadLines("Day2.txt");
int gamePower = 0;
int gameTotal = 0;

foreach (var lineRead in linesRead)
{
   int red = FindAndPrintPrefix(lineRead, "red");
    int green = FindAndPrintPrefix(lineRead, "green");
    int blue = FindAndPrintPrefix(lineRead, "blue");
    
    gamePower = red * green * blue;
    Console.WriteLine ("Game power is {0}", gamePower);
    gameTotal = gameTotal + gamePower;
}



Console.WriteLine(gameTotal);

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
    //Console.WriteLine("Biggest size for game {0} {1} is {2}", gameNumber, targetString, biggestSize);

    return biggestSize;
}
 */