using System.Collections.Generic;
using System.Linq;
using System;

namespace Op_CtrlFlow
{
    public class Exercises
    {

        public static bool MyMethod(int num1, int num2)
        {
            return num1 == num2 ? false : (num1 % num2) == 0;
        }

        // returns the average of the array nums
        public static double Average(List<int> nums)
        {

            if (nums.Count == 0) 
            {
                return 0;
            }
            
            double averageNum = nums.Average();

            return averageNum;
        }

        // returns the type of ticket a customer is eligible for based on their age
        // "Standard" if they are between 18 and 59 inclusive
        // "OAP" if they are 60 or over
        // "Student" if they are 13-17 inclusive
        // "Child" if they are 5-12
        // "Free" if they are under 5
        public static string TicketType(int age)
        {

            if (age >= 18 && age <= 59)
            {
                return "Standard";
            }
            else if (age >= 60)
            {
                return "OAP";
            }
            else if (age >= 13 && age <= 17)
            {
                return "Student";
            }
            else if (age >= 5 && age <= 12)
            {
                return "Child";
            }
            else if (age < 5) 
            {
                return "Free";
            }

            string ticketType = string.Empty;
            return ticketType;
        }

        public static string Grade(int mark)
        {

            if (mark >= 75 && mark <= 100)
            {
                return "Pass with distinction";
            }
            else if (mark >= 60 && mark <= 74)
            {
                return "Pass with merit";
            }
            else if (mark >= 40 && mark <= 59)
            {
                return "Pass";
            }
            else if (mark >= 0 && mark <= 39)
            {
                return "Fail";
            }
            else if (mark > 100 || mark < 0) 
            {
                throw new ArgumentOutOfRangeException("Mark: " + mark + " Allowed range 1-100");
            }

            var Grade = string.Empty;
            return Grade;

        }

        public static int GetScottishMaxWeddingNumbers(int covidLevel)
        {

            switch (covidLevel)
            {
                case 4:
                    covidLevel = 20;
                    break;
                case 3:
                    covidLevel = 50;
                    break;
                case 2:
                    covidLevel = 50;
                    break;
                case 1:
                    covidLevel = 100;
                    break;
                case 0:
                    covidLevel = 200;
                    break;
        }
            return covidLevel;
        }

            }
}
