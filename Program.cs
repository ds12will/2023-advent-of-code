using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

var linesRead = File.ReadLines("Day2.txt");
int total = 0;

foreach (var lineRead in linesRead)
{
    bool gameOn = true;
    gameOn = FindAndPrintPrefix(lineRead, "red", 12);
    if (gameOn == false) { continue; }
    gameOn = FindAndPrintPrefix(lineRead, "green", 13);
    if (gameOn == false) { continue; }
    gameOn = FindAndPrintPrefix(lineRead, "blue", 14);
    if (gameOn == false) { continue; }
    total = total + ParseGame(lineRead);
}

Console.WriteLine(total);

int ParseGame(string lineOfGame)
{
    string[] gameText = lineOfGame.Split(":");
    string[] gameSplit = gameText[0].Split(" ");
    string gamePoints = gameSplit[1];
    return Int32.Parse(gamePoints);
}


bool FindAndPrintPrefix(string input, string targetString, int size)
{
    int index = 0;
    bool gameOn = true;
    var gameNumber = ParseGame(input);
    while ((index = input.IndexOf(targetString, index)) != -1)
    {
        if (index >= 3)
        {
            string prefix = input.Substring(index - 3, 3);
            //Console.WriteLine("Found at index {0}, prefix: {1}", index, prefix);
            if (Int32.Parse(prefix) > size)
            {
                Console.WriteLine("Game {0} wouldn't work", gameNumber);
                return gameOn = false;
            }
        }
        

        index++;
    }

    return gameOn;
}
/* 
Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green
Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue
Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red
Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red
Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green */
