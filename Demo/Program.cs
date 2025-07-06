using Common;
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
        }
    }
}
