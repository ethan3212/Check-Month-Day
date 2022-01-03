using System;

namespace CheckMonth2
{
    class Program
    {
        static void Main(string[] args)
        {
            int MONTH;      // create variables               
            int DAY;        
            
            Console.WriteLine("Enter the numerical value of a month: ");    // get value of MONTH
            MONTH = Convert.ToInt32(Console.ReadLine());
            
            if (MONTH < 1 || MONTH > 12)        // check for validity of MONTH
                Console.WriteLine("This is not a valid month: ");
            
            Console.WriteLine("Enter a day: ");     // get value of DAY
            DAY = Convert.ToInt32(Console.ReadLine());
            
            if (DAY < 1 || DAY > 31)        // check for validity of DAY
                Console.WriteLine("This is not a valid day: ");

            // check if MONTH is a "31-day" month and DAY is less than or equal to 31
            if ((MONTH == 1 || MONTH == 3 || MONTH == 5 || MONTH == 7 || MONTH == 8 || MONTH == 10 || MONTH == 12) && (DAY >= 1 && DAY <= 31))
                Console.WriteLine("The month and the day are valid: ");

            else        // check if MONTH is a "30-day" month and DAY is less than or equal to 30
            if ((MONTH == 4 || MONTH == 6 || MONTH == 9 || MONTH == 11) && (DAY >=1 && DAY <= 30))
                Console.WriteLine("The month and the day are valid: ");

            else        // check if MONTH is February and DAY is less than or equal to 28
                if ((MONTH == 2) && (DAY >= 1 && DAY <= 28))
                Console.WriteLine("The month and the day are valid: ");

            else        // wrong DAY for entered MONTH 
                Console.WriteLine("Wrong day entered for this month: ");
        }
    }
}
