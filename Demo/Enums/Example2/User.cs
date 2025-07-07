
using Demo.Enums.Example1;
using Demo.Enums.Example3;

namespace Demo.Enums.Example2
{
    internal class User
    {
        public int Id { get; set; }
        public Permissions Permissions { get; set; } 
         // Write  read  delete  execute
        //  T       F     F       F
        //public bool[] Permissions = new bool[4]; 
        //public Gender Gender { get; set; }
        //public Grades Grade { get; set; }
        //public Branch Branch { get; set; }

    }
}
