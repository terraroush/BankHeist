using System;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            HireTeamMember();
        }

        static Member HireTeamMember()
        {
            Console.Write("Enter new team member's name: ");
            string enteredName = Console.ReadLine();
            int enteredSkill = InputSkill();
            double enteredCourage = InputCourage();

            Member newTeamMember = new Member(enteredName, enteredSkill, enteredCourage);
            Console.WriteLine($@"{newTeamMember.Name}
            {newTeamMember.SkillLevel}
            {newTeamMember.CourageFactor}");
            return newTeamMember;
        }
        static int InputSkill()
        {
            int entered;
            while (true)
            {
                try
                {
                    Console.Write("Enter new team member's skill level: ");
                    entered = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Must enter a whole number.");
                }
            }
            while (entered <= 0)
            {
                try
                {
                    Console.Write("Enter a number greater than zero: ");
                    entered = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Must enter a whole number.");
                }
            }
            return entered;
        }
        static double InputCourage()
        {
            double entered;

            while (true)
            {
                try
                {
                    Console.Write("Enter new team member's courage (0.0 - 2.0): ");
                    entered = double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Must enter a number between 0.0 - 2.0.");
                }
            }

            while (entered < 0.0 || entered > 2.0)
            {
                try
                {
                    Console.Write("Must enter a number 0.0 - 2.0: ");
                    entered = double.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Must enter a number 0.0 - 2.0: ");
                }
            }
            return entered;
        }
    }
}
