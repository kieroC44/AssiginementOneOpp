using Common;
using Demo.Enums.Example1;
using Demo.Enums.Example2;
using System;
namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Class Libraries
            //Product product = new Product();
            //product.Id = 10;
            //product.Name = "Test";
            //product.Price = 1000;
            //product.Quantity = 1;
            #endregion

            #region Access Modifiers
            //TypeA typeA = new TypeA();
            //typeA.X = 1; //Invalid, Private : accessible in its scope only
            //typeA.Y = 2; //Invalid, Internal :accessible in its scope and in same project only
            //typeA.z = 3;//Valid , accessible in its scope and in same project and any project take reference from its project
            #endregion

            #region Enum Ex 1 [Male - Female]
            //Person p1 = new Person();
            ////1]  Reference [Stack] 4 bytes
            //p1.Id = new();
            //1] allocate num of bytes in heap
            //2] intialize with the defult values
            //3] call user defult ctor[if exist]
            //4] assign referensce to the instant in heap

            //p1.Id = 1;
            //p1.Name = "Kiero";
            //p1.Gender = "male"; 

            //Person p1 = new Person
            //{
            //    Name = "Kiero",
            //    Id = 1,
            //    Gender = (Gender)1,

            //};
            //Console.WriteLine(p1.Gender);
            #endregion

            #region Enum Ex 2 [Grades]
            //Grades g1; // Varibles , object
            //g1 = Grades.A;
            //Console.WriteLine(g1); 


            //Person p1 = new Person();
            //Console.WriteLine(p1.Gender);
            //Console.WriteLine(p1.Grade);


            //int num = (int)Grades.C;
            //Console.WriteLine(num); 

            //Person p1 = new Person()
            //{
            //    Id = 1,
            //    Name = "Mohaned",
            //    Gender = Gender.Male,
            //    Grade = Grades.C
            //};

            //if (p1.Grade == Grades.A)
            //    Console.WriteLine("Bravo");
            //else
            //    Console.WriteLine(":(");



            #endregion

            #region Enum Ex 3 [Grade , Gender , Branch]
            //User user; // Reference
            //user = new User()
            //{
            //    Id = 1,
            //    Name = "Kiero",
            //    Gender = Gender.Male,
            //    Grade = Grades.A,
            //    Branch = Branch.Dokki

            //};
            //Console.WriteLine(user.Grade);
            //Console.WriteLine(user.Gender);
            //Console.WriteLine(user.Branch);

            //User user = new User();
            //Console.WriteLine("Please enter the student info");

            //int stdId;
            //bool isParsed;
            //do
            //{
            //    Console.WriteLine("Please enter the valid student id");
            //    isParsed = int.TryParse(Console.ReadLine(), out stdId); //string?
            //} while (!isParsed);
            //Console.WriteLine("Please enter the valid name");
            //user.Name = Console.ReadLine();
            ////Gender , Grade , Branch
            //object? gender;
            //do
            //{ 

            //    Console.WriteLine("Please enter a valid gender [Male/Female]");
            //    isParsed = Enum.TryParse(typeof(Gender), Console.ReadLine(), true, out gender);

            //} while (!isParsed);
            //    Grades grade;
            //do
            //{
            //    Console.WriteLine("Please enter a valid grade");
            //    isParsed = Enum.TryParse<Grades>(Console.ReadLine(), true, out grade);

            //} while (!isParsed);

            //Console.WriteLine("Please enter a valid branch");
            //Branch branch;

            //do
            //{ 
            //    Console.WriteLine("Please enter a valid branch");
            //    isParsed = Enum.TryParse(Console.ReadLine(), out branch);

            //} while (!isParsed);
            //  user.Id = stdId;
            //  user.Grade = grade;
            //  user.Branch = branch;
            //  user.Gender = (Gender) gender;

            //   Console.Clear();
            //   Console.WriteLine($"Hello {user.Id} , {user. Name}");
            //   Console.WriteLine($"Your gender {user.Gender}");
            //   Console.WriteLine($"Your grade {user. Grade}");
            //   Console.WriteLine($"Your branch {user.Branch}");



        #endregion



    }
    }
}
