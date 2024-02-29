namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = 0;
            Console.WriteLine("pleas enter a max number ");
            maxNumber=int.Parse(Console.ReadLine());
            for(int i = 0; i <= maxNumber; i+=2)
            {
                //find all even numbers with in the max number
                Console.WriteLine(i);

            }
            //Part two
         int numberOfAsteriks =0;
         Console.WriteLine("pleas enter the number of asterisks you want ");
            numberOfAsteriks=int.Parse(Console.ReadLine());
            for(int i = 1; i <= numberOfAsteriks; i++)
            {
                Console.Write("*");
            }
            
        }
    }
}