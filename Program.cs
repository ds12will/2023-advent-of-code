using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

var linesRead = File.ReadLines("Day1.txt");
int total = 0;
foreach (var lineRead in linesRead)
{
    string updatedLineRead = UpdateCoordinates(lineRead);
    string calibration = string.Concat(updatedLineRead.Where(Char.IsDigit));
    int first_digit = calibration[0] - '0';
    int last_digit = calibration[calibration.Length - 1] - '0';
    int newNumber = Convert.ToInt32(string.Format("{0}{1}", first_digit, last_digit));
    Console.WriteLine(newNumber);
    Console.WriteLine("Total is now {0}", total);
    total = newNumber + total;
}
Console.WriteLine(total);


//go through each char
//building a new string
//does that have one of the following
//switch statement

string UpdateCoordinates(string s)
{
    string updatedCoordinate = "";

    foreach (char c in s)
    {
        updatedCoordinate = updatedCoordinate + c;

        switch (updatedCoordinate)
        {
            case var one when updatedCoordinate.Contains("one"):
                updatedCoordinate = updatedCoordinate.Replace("one", "e1e");
                break;
            case var two when updatedCoordinate.Contains("two"):
                updatedCoordinate = updatedCoordinate.Replace("two", "o2o");
                break;
            case var three when updatedCoordinate.Contains("three"):
                updatedCoordinate = updatedCoordinate.Replace("three", "e3e");
                break;
            case var four when updatedCoordinate.Contains("four"):
                updatedCoordinate = updatedCoordinate.Replace("four", "r4r");
                break;
            case var five when updatedCoordinate.Contains("five"):
                updatedCoordinate = updatedCoordinate.Replace("five", "e5e");
                break;
            case var six when updatedCoordinate.Contains("six"):
                updatedCoordinate = updatedCoordinate.Replace("six", "x6x");
                break;
            case var seven when updatedCoordinate.Contains("seven"):
                updatedCoordinate = updatedCoordinate.Replace("seven", "n7n");
                break;
            case var eight when updatedCoordinate.Contains("eight"):
                updatedCoordinate = updatedCoordinate.Replace("eight", "t8t");
                break;
            case var nine when updatedCoordinate.Contains("nine"):
                updatedCoordinate = updatedCoordinate.Replace("nine", "e9e");
                break;
            default:
                break;

        };

        //oneeight
        //twoone
        //threeeight
        //fiveeight
        //sevennine
        //eighttwo
        //eightthree
        //nineeight


        Console.WriteLine(updatedCoordinate);




    }
    return updatedCoordinate;
}

