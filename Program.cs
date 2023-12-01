var linesRead = File.ReadLines("Day1.txt");
int total = 0;
        foreach (var lineRead in linesRead)
        {
            string calibration = string.Concat( lineRead.Where( Char.IsDigit ));
            int first_digit = calibration[0] - '0';
            int last_digit = calibration[calibration.Length - 1 ] - '0';
            int newNumber = Convert.ToInt32(string.Format("{0}{1}", first_digit, last_digit));
            Console.WriteLine("Total is now {0}", total);
           total = newNumber + total;
        }
        Console.WriteLine(total);
