using System;

namespace LeapYear
{
    class Program
    {
        enum MonthName
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter the year: ");
                int yearNum = int.Parse(Console.ReadLine());

                bool isLeapYear = (yearNum % 4 == 0) && ((yearNum % 100 != 0) || (yearNum % 100 == 0));
                int maxDayNum = isLeapYear ? 365 : 366;
                if (isLeapYear)
                {
                    Console.WriteLine("Is a leap year");
                }
                else
                {
                    Console.WriteLine("Is NOT a leap year");
                }
                Console.Write("Please enter a day number between 1 and 365: ");
                int dayNum = int.Parse(Console.ReadLine());

                if ((dayNum < 1) || (dayNum > maxDayNum))
                {
                    throw new ArgumentOutOfRangeException("Day out of range");
                }

                int monthNum = 0;
                var DaysInMonths = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                var DaysInLeapMonths = new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                if (isLeapYear)
                {
                    foreach (int daysInMonth in DaysInLeapMonths)
                    {
                        if (dayNum <= daysInMonth)
                        {
                            break;
                        }
                        else
                        {
                            dayNum -= daysInMonth;
                            monthNum++;
                        }
                    }
                }
                else
                {
                    foreach (int daysInMonth in DaysInMonths)
                    {
                        if (dayNum <= daysInMonth)
                        {
                            break;
                        }
                        else
                        {
                            dayNum -= daysInMonth;
                            monthNum++;
                        }
                    }
                }
                MonthName temp = (MonthName)monthNum;
                string monthName = temp.ToString();
                Console.WriteLine("{0} {1} {2}", dayNum, monthName, yearNum);
            }
            catch (Exception caught)
            {
                Console.WriteLine(caught);
            }
            Console.ReadKey();
        }
    }
}