using System;

namespace my_day
{
    class homework
    {   // version12
        // function to implement tomohiko sakamoto algorithm in order to find the day of week.
        // reference:https://www.geeksforgeeks.org/tomohiko-sakamotos-algorithm-finding-day-week/
        public static int day_of_the_week(int y, int m, int d)
        {

            int t = 0;
            // if month is less than 3 reduce year by 1
            if (m < 3)
                y -= 1;
            switch (m)
            {
                case 1:
                    t = 0;
                    break;
                case 2:
                    t = 3;
                    break;
                case 3:
                    t = 2;
                    break;
                case 4:
                    t = 5;
                    break;
                case 5:
                    t = 0;
                    break;
                case 6:
                    t = 3;
                    break;
                case 7:
                    t = 5;
                    break;
                case 8:
                    t = 1;
                    break;
                case 9:
                    t = 4;
                    break;
                case 10:
                    t = 6;
                    break;
                case 11:
                    t = 2;
                    break;
                case 12:
                    t = 4;
                    break;
            }

            return (y + y / 4 - y / 100 + y / 400 + t + d) % 7;
        }

        static void Main(string[] args)
        {
            int year = 0, month = 0, day = 0, step = 0, dayfrom2015 = 0, stepafter = 0;
            int d1 = 0, m1 = 0, y1 = 0, d2 = 0, m2 = 0, y2 = 0, weekday = 0, monthday = 0;
            int first_day, first_year, second_day, second_year, numeric;
            int dayofyear = 0, previous_year = 0, month1 = 0, month2 = 0;
            string days = "", first_month, second_month;
            bool succes, result1, result2;
            string season = "", next_season = "";


            // end of declaration table

            Console.WriteLine("Please enter the day of first date: ");
            succes = Int32.TryParse(Console.ReadLine(), out numeric);
            if (!succes || numeric < 0)//This condition controls if user entered a numeric value,if not it displays an error message.
            {
                Console.WriteLine("ERROR: Day must be a positive numeric value.Press enter to exit.");
                Console.ReadLine();
                return;
            }
            first_day = numeric;
            Console.WriteLine("Please enter the month of first date: ");
            first_month = Console.ReadLine();
            first_month = first_month.ToLower();
            Console.WriteLine("Please enter the year of first date:");
            succes = Int32.TryParse(Console.ReadLine(), out numeric);
            if (!succes || numeric < 0)
            {
                Console.WriteLine("ERROR: Year must be a positive numeric value.Press enter to exit.");
                Console.ReadLine();
                return;
            }
            first_year = numeric;
            if (first_year < 2015 || first_year == 2015 && first_month == "january" && first_day == 1)
            //this condition checks if the date is 01.01.2015 or before and displays an error message.
            {
                Console.WriteLine("ERROR: Date must be later then 01.01.2015.Press enter to exit.");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Please enter the day of second date: ");
            succes = Int32.TryParse(Console.ReadLine(), out numeric);
            if (!succes || numeric < 0)
            {
                Console.WriteLine("ERROR: Day must be a positive numeric value.Press enter to exit.");
                Console.ReadLine();
                return;
            }
            second_day = numeric;
            Console.WriteLine("Please enter the month of second date: ");
            second_month = Console.ReadLine();
            second_month = second_month.ToLower();
            Console.WriteLine("Please enter the year of second date: ");
            succes = Int32.TryParse(Console.ReadLine(), out numeric);
            if (!succes || numeric < 0)
            {
                Console.WriteLine("ERROR: Year must be a positive numeric value.Press enter to exit.");
                Console.ReadLine();
                return;
            }
            second_year = numeric;
            if (first_year == second_year && first_month == second_month && first_day == second_day)
            //this condition checks if the first date equals to second date and displays an error message.
            {
                Console.WriteLine("ERROR: First date can be before or after the second date.Press enter to exit.");
                Console.ReadLine();
                return;
            }


            month1 = 0;
            switch (first_month)// this switch-case changes type of the month variable from string to integer.
            {
                case "january":
                    result1 = int.TryParse("01", out month1);
                    break;
                case "february":
                    result1 = int.TryParse("02", out month1);
                    break;
                case "march":
                    result1 = int.TryParse("03", out month1);
                    break;
                case "april":
                    result1 = int.TryParse("04", out month1);
                    break;
                case "may":
                    result1 = int.TryParse("05", out month1);
                    break;
                case "june":
                    result1 = int.TryParse("06", out month1);
                    break;
                case "july":
                    result1 = int.TryParse("07", out month1);
                    break;
                case "august":
                    result1 = int.TryParse("08", out month1);
                    break;
                case "september":
                    result1 = int.TryParse("09", out month1);
                    break;
                case "october":
                    result1 = int.TryParse("10", out month1);
                    break;
                case "november":
                    result1 = int.TryParse("11", out month1);
                    break;
                case "december":
                    result1 = int.TryParse("12", out month1);
                    break;
                default:
                    Console.WriteLine("ERROR: Month is wrong.Press enter to exit.");
                    Console.ReadLine();
                    return;
                    break;

            }
            month2 = 0;
            switch (second_month) //this switch-case changes type of the month variable from string to integer.
            {
                case "january":
                    result2 = int.TryParse("01", out month2);
                    break;
                case "february":
                    result2 = int.TryParse("02", out month2);
                    break;
                case "march":
                    result2 = int.TryParse("03", out month2);
                    break;
                case "april":
                    result2 = int.TryParse("04", out month2);
                    break;
                case "may":
                    result2 = int.TryParse("05", out month2);
                    break;
                case "june":
                    result2 = int.TryParse("06", out month2);
                    break;
                case "july":
                    result2 = int.TryParse("07", out month2);
                    break;
                case "august":
                    result2 = int.TryParse("08", out month2);
                    break;
                case "september":
                    result2 = int.TryParse("09", out month2);
                    break;
                case "october":
                    result2 = int.TryParse("10", out month2);
                    break;
                case "november":
                    result2 = int.TryParse("11", out month2);
                    break;
                case "december":
                    result2 = int.TryParse("12", out month2);
                    break;
                default:
                    Console.WriteLine("ERROR: Month is wrong.Press enter to exit.");
                    Console.ReadLine();
                    return;
                    break;
            }
            Console.WriteLine("First Date: ");
            Console.Write(first_day);
            Console.Write(".");
            Console.Write(month1);
            Console.Write(".");
            Console.Write(first_year);
            Console.ReadLine();
            Console.WriteLine("Second Date: ");
            Console.Write(second_day);
            Console.Write(".");
            Console.Write(month2);
            Console.Write(".");
            Console.Write(second_year);
            Console.ReadLine();
            Console.WriteLine("Please enter a number: ");
            succes = Int32.TryParse(Console.ReadLine(), out numeric);
            if (!succes)
            {
                Console.WriteLine("ERROR: Number must be a numeric value.Press enter to exit.");
                Console.ReadLine();
                return;
            }
            step = numeric;//lets say step=n,this makes program count n days between given dates.

            if (month1 == 1 || month1 == 3 || month1 == 5 || month1 == 7 || month1 == 8 || month1 == 10 || month1 == 12 || month2 == 1 || m2 == 3 || month2 == 5 || month2 == 7 || month2 == 8 || month2 == 10 || month2 == 12)
            {
                if (first_day > 31)
                {
                    Console.WriteLine("ERROR: Day is wrong.Day can be 31 at most for first month.Press enter to exit.");
                    Console.ReadLine();
                    return;
                }
                if (second_day > 31)
                {
                    Console.WriteLine("ERROR: Day is wrong.Day can be 31 at most for second month.Press enter to exit.");
                    Console.ReadLine();
                    return;
                }

            }
            if (month1 == 2 || month2 == 2)
            {
                if (((first_year % 4 == 0) && (first_year % 100 != 0)) || (first_year % 400 == 0))
                // this condition checks if the year is leap year;if condition is true february has 29 days, if not it has 28 days.
                {
                    if (first_day > 29)
                    {
                        Console.WriteLine("ERROR: Day is wrong.Day can be 29 at most for first month in this year.Press enter to exit.");
                        Console.ReadLine();
                        return;
                    }

                }
                else
                {
                    if (first_day > 28 || first_day > 28)
                    {
                        if (first_day > 28)
                        {
                            Console.WriteLine("ERROR: Day is wrong.Day can be 28 at most for first month in this year.Press enter to exit.");
                            Console.ReadLine();
                            return;
                        }
                        if (second_day > 28)
                        {
                            Console.WriteLine("ERROR: Day is wrong.Day can be 28 at most for second month in this year.Press enter to exit.");
                            Console.ReadLine();
                            return;
                        }


                    }
                }


                if (((second_year % 4 == 0) && (second_year % 100 != 0)) || (second_year % 400 == 0))
                {
                    if (second_day > 29)
                    {
                        Console.WriteLine("ERROR: Day is wrong.Day can be 29 at most for second month in this year.Press enter to exit.");
                        Console.ReadLine();
                        return;
                    }
                }
                else
                {
                    if (first_day > 28 || second_day > 28)
                    {
                        if (first_day > 28)
                        {
                            Console.WriteLine("ERROR: Day is wrong.Day can be 28 at most for first month in this year.Press enter to exit.");
                            Console.ReadLine();
                            return;
                        }
                        if (second_day > 28)
                        {
                            Console.WriteLine("ERROR: Day is wrong.Day can be 28 at most for second month in this year.Press enter to exit.");
                            Console.ReadLine();
                            return;
                        }


                    }
                }
            }


            else
            {
                if (first_day > 30)
                {
                    Console.WriteLine("ERROR: Day is wrong.Day can be 30 at most for first month.Press enter to exit.");
                    Console.ReadLine();
                    return;

                }
                if (second_day > 30)
                {
                    Console.WriteLine("ERROR: Day is wrong.Day can be 30 at most for second month.Press enter to exit.");
                    Console.ReadLine();
                    return;

                }
            }

            //if the second date user entered is before first date we need to swap the dates.In order to do that we need another variable which acts as a buffer.
            if (second_year < first_year || second_year == first_year && month2 < month1 || second_year == first_year && month2 == month1 && second_day < first_day)
            {
                y1 = second_year;
                y2 = first_year;
                m1 = month2;
                m2 = month1;
                d1 = second_day;
                d2 = first_day;

            }
            else
            {
                y1 = first_year;
                y2 = second_year;
                m1 = month1;
                m2 = month2;
                d1 = first_day;
                d2 = second_day;

            }




            for (year = 2015; year <= y2; year++)//we start from 2015.If year changed we increase year by 1.
            {

                if (previous_year != year)
                {
                    previous_year = year;

                }

                for (month = 1; month <= 12; month++)//we start from month 1.If month changed we increase month by 1.
                {
                    if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                    {
                        monthday = 31;
                    }
                    if (month == 4 || month == 6 || month == 9 || month == 11)
                    {
                        monthday = 30;
                    }
                    if (month == 2)
                    {
                        if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                        {
                            monthday = 29;

                        }
                        else
                        {
                            monthday = 28;

                        }
                    }
                    for (day = 1; day <= monthday; day++)// this 3 loops make the date increase day by day then changes month and year if needed.
                    {
                        dayfrom2015 = dayfrom2015 + 1;// this statement counts day from 2015, with help of this we can count more than 31 days in calendar.


                        if ((day == d1 && month == m1 && year == y1) || (dayfrom2015 == stepafter))
                        // to print the first day we have first condition.After that it continues printing days because of second condition.
                        {
                            stepafter = dayfrom2015 + step;
                            weekday = day_of_the_week(year, month, day);
                            if (weekday == 0) { days = "Sunday"; }
                            else if (weekday == 1) { days = "Monday"; }
                            else if (weekday == 2) { days = "Tuesday"; }
                            else if (weekday == 3) { days = "Wednesday"; }
                            else if (weekday == 4) { days = "Thursday"; }
                            else if (weekday == 5) { days = "Friday"; }
                            else if (weekday == 6) { days = "Saturday"; }
                            if ((year == y2 && month == m2 && day <= d2) || (year < y2) || (y1 == y2 && month <= m2 && day <= d2) || (y1 == y2 && month < m2) || (year == y2 && month < m2))
                            //this conditions make the last control,if at least one of them is true program prints the day, id they are all false we made it to end of calendar.
                            {

                                if ((month == 3 || month == 4 || month == 5))
                                {
                                    season = "SPRING";


                                }
                                if ((month == 6 || month == 7 || month == 8))
                                {
                                    season = "SUMMER";


                                }
                                if ((month == 9 || month == 10 || month == 11))
                                {
                                    season = "AUTUMN";


                                }
                                //                                                
                                if (month == 12 || month == 1 || month == 2)
                                {
                                    season = "WINTER";


                                }

                                if (season != next_season)// this condition checks if season has changed.If so,it prints season and sets next season to season.
                                {
                                    Console.WriteLine("    ");
                                    Console.WriteLine(season);
                                    Console.WriteLine("    ");
                                    next_season = season;

                                }
                                string get_name_of_month(int month_name)
                                {

                                    switch (month_name)
                                    {
                                        case 1:
                                            return "January";
                                            break;
                                        case 2:
                                            return "February";
                                            break;
                                        case 3:
                                            return "March";
                                            break;
                                        case 4:
                                            return "April";
                                            break;
                                        case 5:
                                            return "May";
                                            break;
                                        case 6:
                                            return "June";
                                            break;
                                        case 7:
                                            return "July";
                                            break;
                                        case 8:
                                            return "August";
                                            break;
                                        case 9:
                                            return "September";
                                            break;
                                        case 10:
                                            return "October";
                                            break;
                                        case 11:
                                            return "November";
                                            break;
                                        case 12:
                                            return "December";
                                            break;
                                        default: return "January"; //using January as default in case of any possible danger.
                                    }
                                }

                                Console.WriteLine(day + "   " + get_name_of_month(month) + "   " + year + "   " + days);

                            }
                        }


                    }
                }

            }
            Console.ReadLine();

        }
    }

}
