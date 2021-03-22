using System;

namespace Lab3._1StudentInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = {"Kyle", "Jeff", "Kirk", "Jason", "Michael", "Ricky", "Lassiter",
            "Alaa", "Katub", "Laura" ,"Verkeia", "Helen"};
            string[] favFood = {"Pizza", "Pasta", "Shrimp", "Steak", "Stir Fry", "Apples", "Chicken",
            "Turkey", "Salad", "Ice Cream", "Apple Pie", "Chocolate Chip Cookies"};
            string[] previousPosition = {"Help Desk Support", "Intern", "Team Leader", "Sr. Accountant",
            "Associate Banker", "Senior Banker", "Sr. Cash Auditor", "Security Guard", "Product Owner",
            "Marketing Associate", "Pricing Director", "Executive Banker"};

            Console.WriteLine("Welcome to our Dev.Build class!");

            bool validNumber = false;
            int studentSelect;
            string userWantsToContinue;

            Console.WriteLine("Would you like to see a list of the students? (y/n)");

            string seeList = Console.ReadLine().ToLower();
            if (seeList == "y")
            {
                for (int i = 0; i < name.Length; i++)
                {
                    Console.WriteLine(name[i]);
                }
            }

            do
            {
                Console.WriteLine("Which student would you like to learn more about? (enter a number 0-11):");
                studentSelect = Int32.Parse(Console.ReadLine());
                while (validNumber == false)
                {
                    try
                    { 
                        if (studentSelect >= 0 && studentSelect <= 11)
                        {
                            validNumber = true;
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("This is an invalid entry, please try again!");
                    }
                }
                Console.WriteLine($"Student {studentSelect} is {name[studentSelect]}. What would you like to " +
                    $"know about {name[studentSelect]}? (enter \"favorite food\" or \"previous title\"):");

                bool validCategory = false;
                string categorySelect = Console.ReadLine().ToLower();

                while (validCategory == false)
                {

                     if (categorySelect == "favorite food")
                     {
                        Console.WriteLine($"{name[studentSelect]}'s favorite food is {favFood[studentSelect]}.");
                        validCategory = true;
                     }
                     else if (categorySelect == "previous title")
                     {
                        Console.WriteLine($"{name[studentSelect]}'s previous title is {previousPosition[studentSelect]}.");
                        validCategory = true;
                     }
                     else
                     {
                        Console.WriteLine("That data does not exist. Please try again. (enter \"favorite " +
                        "food\" or \"previous title\"");
                        categorySelect = Console.ReadLine().ToLower();
                     }
                    
                }
                Console.WriteLine("Would you like to know about another student? (y/n)");

                userWantsToContinue = Console.ReadLine().ToLower();

            } while (userWantsToContinue == "y");

            Console.WriteLine("Thanks for learning more about the students!");
        }
    }
}
