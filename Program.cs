// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// this will read all lines from within the File
        // and automatically put them into an array
        //
var linesRead = File.ReadLines("Day1.txt");
int total = 0;
        foreach (var lineRead in linesRead)
        {
            //Console.WriteLine(string.Concat( lineRead.Where( Char.IsDigit ) ));
            string calibration = string.Concat( lineRead.Where( Char.IsDigit ));
            int first_digit = calibration[0] - '0';
            int last_digit = calibration[calibration.Length - 1 ] - '0';
            //Console.WriteLine("First digit of {0} is {1}", calibration, first_digit);
            //Console.WriteLine("Last digit of {0} is {1}", calibration, last_digit);
            int newNumber = Convert.ToInt32(string.Format("{0}{1}", first_digit, last_digit));
            Console.WriteLine("Total is now {0}", total);
           total = newNumber + total;
        }
        Console.WriteLine(total);

//string.Concat( input.Where( Char.IsDigit ) );
//int first_digit = s[0] - '0';
//        int last_digit = s[s.Length - 1] - '0';
//        Console.WriteLine("First digit of {0} is {1}", n, first_digit);
//        Console.WriteLine("Last digit of {0} is {1}", n, last_digit);
