using System;

namespace GetDoubleInputFromUser
{
    class Program
    {
        static double userNum;
        static string response;
        static double getDoubleInputsFromUser(string input)
        {
            Console.WriteLine(input);
            response = Console.ReadLine();
            if (double.TryParse(response, out userNum) == false)
            {
                do
                {
                    Console.WriteLine("This is not a valid number. Please try again");
                    response = Console.ReadLine();
                }
                while (double.TryParse(response, out userNum) == false);
            }
            
            {
                userNum = Convert.ToDouble(response) * 5;
            }
            Console.WriteLine("The product of the number you entered is " + userNum);
            return userNum;
        }
            static void Main(string[] args)
        {
            string question = "Enter a number you would like to multiply by 5.";
            getDoubleInputsFromUser(question);
        }
    }
}
