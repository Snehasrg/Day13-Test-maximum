namespace TestMaximum
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Find Maximum Problem using Generics");

            

            int num = FindGenericVariable<int>.MaxNumber(9, 77, 200);
            Console.WriteLine("The greater Integer number is : " + num);
        }
    }
}
