
namespace Demo.UserDefiendDataTypes
{
    internal struct MyStruct
    {
        //Access modifiers allowed inside struct ==> [Internal , Public , Privete]
        //defult access modifier inside struct ==> private

        //1] Attributes [Fields]
        int x ;
        //2] Properties 
        public int Id { get; set; }
        //3] Events

        //4] Methods
        int Sum(int x, int y )
        {
            return  x + y;
        }
    }
}
