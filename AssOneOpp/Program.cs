using AssOneOpp.Enums;
using AssOneOpp.Structs;
using System;

namespace AssOneOpp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Task
            //StructTask student;

            //Console.Write("Enter student name: ");
            //student.Name = Console.ReadLine();

            //Console.Write("Enter student grade (A, B, C, D, F): ");
            //string gradeInput = Console.ReadLine();


            //if (gradeInput == "A" || gradeInput == "B" || gradeInput == "C" || gradeInput == "D" || gradeInput == "F")
            //{
            //    Grade parsedGrade = (Grade)Enum.Parse(typeof(Grade), gradeInput);
            //    student.Grade = parsedGrade;

            //    Console.WriteLine($"\nStudent: {student.Name}");
            //    Console.WriteLine($"Grade: {student.Grade}");

            //    switch (gradeInput)
            //    {
            //        case "A":
            //        case "B":
            //            Console.WriteLine("Message: Excellent");
            //            break;
            //        case "C":
            //            Console.WriteLine("Message: Good job");
            //            break;
            //        case "D":
            //            Console.WriteLine("Message: Needs improvement");
            //            break;
            //        case "F":
            //            Console.WriteLine("Message: Failed. Try again");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid grade entered.");
            //}
            #endregion


            #region 1.Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            //Console.WriteLine("Days of the Week:\n");

            //for (int i = 0; i <= 6; i++)
            //{
            //    WeekDays day = (WeekDays)i;
            //    Console.WriteLine($"{i + 1}. {day}");
            //}
            #endregion

            #region 2.Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
            //PersonQ2[] people = new PersonQ2[3];

            //for (int i = 0; i < people.Length; i++)
            //{
            //    Console.Write($"Enter name of person {i + 1}: ");
            //    people[i].Name = Console.ReadLine();

            //    Console.Write($"Enter age of person {i + 1}: ");
            //    people[i].Age = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("\nPeople info:");
            //foreach (PersonQ2 p in people)
            //{
            //    Console.WriteLine($"Name: {p.Name}, Age: {p.Age}");
            //}
            #endregion

            #region 3.Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //Console.Write("Enter a season name (Spring, Summer, Autumn, Winter): ");
            //string input = Console.ReadLine();

            //if (Enum.TryParse(input, true, out SeasonQ3 season))
            //{
            //    switch (season)
            //    {
            //        case SeasonQ3.Spring:
            //            Console.WriteLine("March to May");
            //            break;
            //        case SeasonQ3.Summer:
            //            Console.WriteLine("June to August");
            //            break;
            //        case SeasonQ3.Autumn:
            //            Console.WriteLine("September to November");
            //            break;
            //        case SeasonQ3.Winter:
            //            Console.WriteLine("December to February");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid season name.");
            //}
            #endregion

            #region 4.Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum. ⮚Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable
            //    PermissionsQ4 userPermissions = PermissionsQ4.Read | PermissionsQ4.Write;

            //    Console.WriteLine("Initial Permissions: " + userPermissions);


            //    userPermissions |= PermissionsQ4.Delete;
            //    Console.WriteLine("After Adding Delete: " + userPermissions);


            //    userPermissions &= ~PermissionsQ4.Write;
            //    Console.WriteLine("After Removing Write: " + userPermissions);


            //    bool hasRead = (userPermissions & PermissionsQ4.Read) == PermissionsQ4.Read;
            //    Console.WriteLine("Has Read Permission? " + hasRead);
            //}
            #endregion

            #region 5.Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            //Console.Write("Enter a color name: ");
            //string input = Console.ReadLine();

            //if (Enum.TryParse(input, true, out ColorsQ5 color))
            //{
            //    Console.WriteLine($"{color} is a primary color.");
            //}
            //else
            //{
            //    Console.WriteLine($"{input} is not a primary color.");
            //}
            #endregion

            #region 6.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

            #endregion

            #region 7.Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

            #endregion



        }
    }
}
