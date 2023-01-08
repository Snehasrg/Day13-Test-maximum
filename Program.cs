namespace TestMaximum
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Find Maximum Problem using Generics");

            string L = "Red";
            string M = "Yellow";
            string N = "Purple";

            string val2 = MaxString<string>.MaxStringNum(L, M, N);
            Console.WriteLine("The greater String is " + val2);
        }
    }
}
