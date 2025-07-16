using Common;
using Demo.Enums.Example1;
using Demo.Enums.Example2;
using Demo.Enums.Example3;
using Demo.Structs;
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

            #region Permission enum
            //User user1 = new User();
            //user1.Id = 10;
            ////Write read delete execute
            //user1.Permissions[0] = true;
            //user1.Permissions[1] = false;
            //user1.Permissions[2] = true;
            //user1.Permissions[3] = false;
            ////Id : int == > 4 bytes , 4bytes == > 8 bytes
            //User user2 = new User();
            //user2.Id = 10;
            ////Write read delete execute
            //user2.Permissions[0] = true;
            //user2.Permissions[1] = false;
            //user2.Permissions[2] = true;
            //user2.Permissions[3] = false;
            //8 bytes


            //User user = new User();
            //user.Id = 1;
            //user.Permissions = Permissions. Delete;
            //Console.WriteLine(user.Permissions);
            //user.Permissions = Permissions. Read;
            //Console.WriteLine(user.Permissions);

            /*
              Write = 0b_0000_0001, //1
              Read = 2, // 2
              Delete = 4,//4
              Execute = 8//8
            */

            //User user = new User();
            //user.Id = 1;



            //user.Permissions = user.Permissions ^ Permissions.Delete;

            //Console.WriteLine(user.Permissions);
            //user.Permissions = user.Permissions ^ Permissions.Delete;
            //Console.WriteLine(user.Permissions); // Write , delete


            //& == > check if permission exist or not
            //Permissions permission = user.Permissions & Permissions.Delete;
            //Console.WriteLine(permission);
            //if((user.Permissions & Permissions. Delete) == Permissions.Delete
            //Console.WriteLine("Permission delete already exist");
            //else
            //{
            //    user.Permissions ^= Permissions.Delete;
            //    Console.WriteLine("Permission added");
            //}
            //Console.WriteLine(user.Permissions)



            //Or => add permission if not exist
            // == > Permission exist [Keep]
            //user.Permissions = (Permissions)1;
            //Console.WriteLine(user.Permissions);
            //user.Permissions |= Permissions.Read;
            //Console.WriteLine(user.Permissions);



            //XOR == > IF Permission Not Exist [Add]
            //  == > IF Permission Exist[Remove]

            //user.Permissions = (Permissions)15;
            //Console.WriteLine(user.Permissions);
            //Bitwise operators [| , & , ^]

            //Permissions permissions;
            //permissions = Permissions.Delete | Permissions.Read;
            //Console.WriteLine(permissions);

            #endregion

            #region Struct Ex1
            //Point p1;
            ////Variable [Value type]
            //p1 = new Point();
            ////new == > Value type [Constructor selection]
            //Console.WriteLine(p1.X);
            //Console.WriteLine(p1.Y);


            //Point p2 = new Point(100);
            //Console.WriteLine(p2.ToString()); //Performance [Better]
            //Console.WriteLine(p2); //p2 [Value type] == > Object [Slower]
            //Console.WriteLine(p2.X);
            //Console.WriteLine(p2.Y);
            #endregion

            #region Struct Ex 2
            //Point p1 = new Point() { X = 10, Y = 20 };
            //Point p2 = new Point() { X = 30, Y = 40 };
            //Console.WriteLine(p1);
            //Console.WriteLine(p2);
            //p2 = p1;
            ////p1 [10 , 20] , p2 [10 ,20]
            //Console.WriteLine();
            //Console.WriteLine(p1);
            //Console.WriteLine(p2);
            //Console.WriteLine();
            //p1.X = 100;
            //p1.Y = 200;
            //Console.WriteLine(p1);
            //Console.WriteLine(p2);


            #endregion









        }
    }
}
