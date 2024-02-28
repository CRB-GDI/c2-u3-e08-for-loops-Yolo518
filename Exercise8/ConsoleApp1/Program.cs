namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = 0;
            Console.WriteLine("pleas enter a max number ");
            maxNumber=int.Parse(Console.ReadLine());
            for(int i = 2; i <= maxNumber; i++)
            {
                //find all even numbers with in the max number
                if (maxNumber % i == 0) 
                {
                    Console.WriteLine(maxNumber % i);
                }

            }
            
        }
    }
}