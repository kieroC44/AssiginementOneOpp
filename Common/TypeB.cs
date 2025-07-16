
namespace Common
{
    internal class TypeB
    {
        public TypeB() 
        {
            TypeA tepeA = new();
            //tepeA.x = 10;//x //accessible in its scope only
            tepeA.y = 20;//Y /accessible in its scope and its same project only
            tepeA.z = 30;//z //accessible in its scope and its same project

        }
    }
}
