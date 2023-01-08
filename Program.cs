namespace TestMaximum
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Find Maximum Problem using Generics");

            float A = 40.5F;
            float B = 50.6F;
            float C = 80.9F;

            float val = MaxFloat<float>.MaxFloatNum(A, B, C);
            Console.WriteLine("The greater Float Num  is " + val);
        }
    }
}
