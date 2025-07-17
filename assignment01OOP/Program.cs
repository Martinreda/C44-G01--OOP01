using assignment01OOP.classes;
using System.ComponentModel;
using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assignment01OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q 01 
            /*1-Create an Enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. 
             * Then, write a C# program that prints out all the days of the week using this Enum.*/

            //int i = 1;

            //foreach (WeekDays Value in Enum.GetValues(typeof(WeekDays)))
            //{

            //    Console.WriteLine($"Day {i} : {Value}");
            //    i++;
            //}
            #endregion

            #region Q 02
            /* 2 - Create an Enum called "Seas on" with the four seasons(Spring, Summer, Autumn, Winter) 
                 as its members.Write a C# program that takes a season name as input from the user and displays the corresponding 
                 month range for that season. Note range for seasons 
                 ( spring march to may , summer june to august , autumn September to November , winter December to February)*/


            //Console.WriteLine("Enter a season name (Spring, Summer, Autumn, Winter):");
            //string input = Console.ReadLine();

            //if (Enum.TryParse(input, true, out Season season))
            //{
            //    if (season == Season.Spring)
            //    {
            //        Console.WriteLine("Spring: March to May");
            //    }
            //    else if (season == Season.Summer)
            //    {
            //        Console.WriteLine("Summer: June to August");
            //    }
            //    else if (season == Season.Autumn)
            //    {
            //        Console.WriteLine("Autumn: September to November");
            //    }
            //    else if (season == Season.Winter)
            //    {
            //        Console.WriteLine("Winter: December to February");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid season name. Please enter Spring, Summer, Autumn, or Winter.");
            //}
            #endregion

            #region Q03
            /* 3 - Assign the following Permissions(Read, write, Delete, Execute) in a form of Enum           .
                 Create Variable from previous Enum to Add and Remove Permission from variable, check if specific 
                 Permission existed inside variable*/

            //Users user = new Users();

            //user.Permissions |= Permissions.read;
            //user.Permissions |= Permissions.Write;

            //Console.WriteLine($"Current Permissions: {user.Permissions}");

            //user.Permissions ^= Permissions.Write;
            //Console.WriteLine($"Current Permissions: {user.Permissions}");

            //user.Permissions |= Permissions.excute;

            //Console.WriteLine($"Final Permissions: {user.Permissions}");

            //if (!user.Permissions.HasFlag(Permissions.delete))
            //{
            //    Console.WriteLine("User does NOT have Delete permission.");
            //}

            #endregion

            #region Q 04 
            /*4.Create an Enum called "Colors" with the basic colors (Red, Green, Blue) as its members.
           * Write a C# program that takes a color name as input from the user and displays a message
             * indicating whether the input color is a primary color or not.*/

            Console.WriteLine("Enter a Color name (Red, Green, Blue):");
            string input = Console.ReadLine();

            if (Enum.TryParse(input, true, out Colors Colors))
            {
                Console.WriteLine("color is a primary color ");
            }
            else
                Console.WriteLine("color is not a primary color ");

            #endregion
        }
    }
}
