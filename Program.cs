namespace TestMaximum
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Find Maximum Problem using Generics");


           // Max3Parameter<int> obj = new Max3Parameter<int>(66, 99, 92);
           // obj.MaxMethod();

            PrintMax<int> obj = new PrintMax<int>(66, 99, 92);
            obj.MaxMethod();

        }
    }
}
