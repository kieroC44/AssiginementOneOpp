
namespace Demo.UserDefiendDataTypes
{
    internal interface IMyInterFace
    {
        //Defult access modifier inside interface ==> public
        //1]Signature of method
        void MyFun(int X, int Y);
        //2]Signature of prop
        public int Id { get; set; }
        //3]Default implemented method 
        private void Helper() 
        {
            Console.WriteLine("Hello");
        
        }
        void Print ()
        {
            Helper();
            Console.WriteLine("Hllo from Print");

        }
     } 
}
