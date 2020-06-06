using System;

namespace Lesson_25_Enumerations
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Welcome to CodeNest.\nLet's get you registered.");
           Console.WriteLine("What is your first name?");
           string FirstNameEntry=Console.ReadLine();
           Console.WriteLine("What is your last name?");
           string LastNameEntry=Console.ReadLine();
           Console.WriteLine("What would you like to sign up as?\n(1 for student, 2 for mentor, 3 for tutor.)");
           int RoleEntry=GetValidRoleEntry();
           CodeNestRoles RolePicked=(CodeNestRoles)RoleEntry;

           Person PersonToAdd=new Person(){
            FirstName=FirstNameEntry,
            LastName=LastNameEntry,
            Role=RolePicked
           };
           Console.WriteLine($"Dear {PersonToAdd.FirstName}, thank you for registering. Your selected role is {PersonToAdd.Role}.");
        }
        static int GetValidRoleEntry(){
           var RoleEntry=int.Parse(Console.ReadLine());
           if(RoleEntry<1||RoleEntry>3)
           {
               Console.WriteLine("Your input was not within range. Please try again.\n(1 for student, 2 for mentor, 3 for tutor.)");
               
               //recursion
               GetValidRoleEntry();
           }
           return RoleEntry;
        }
    }
}
