using assignment01OOP.classes;

namespace assignment01OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q 01 
            /*1-Create an Enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. 
             * Then, write a C# program that prints out all the days of the week using this Enum.*/

            int i = 1;

            foreach (WeekDays Value in Enum.GetValues(typeof(WeekDays)))
            {
             
                Console.WriteLine($"Day {i} : {Value}");
                i++;
            }
            #endregion
        }
    }
}
