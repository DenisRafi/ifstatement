using System;
using static System.Console;

namespace _
{
    class _
    {
        static void Main()
        {
            Title = "DR";
            int userAge;
            Write("Please enter your age: ");
            userAge = Convert.ToInt32(ReadLine());
            if (userAge < 0 || userAge > 100)
            {
                Write("Invalid Age");
                Write("Age must be between 0 and 100");
            }
            else if (userAge < 18)
                Write("Sorry you are underage");
            else if (userAge < 21)
                Write("You need parental consent");
            else
            {
                Write("Congratulations!\nYou may sign up for the event!");                
            }
            ReadKey();
        }
    }
}
