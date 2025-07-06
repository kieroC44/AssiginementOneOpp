
namespace Common
{
    public class TypeA
    {
        private int x;//accessible in their scope
        internal int y; //accessible in their scope
        public int z; //accessible in their scope

        public TypeA()
        {
            x = 1;
            y = 2; 
            z = 3;
        }
 
    }
}
