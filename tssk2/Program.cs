namespace tssk2;

class Program
{
    static void Main(string[] args)
    {
       // task1 countdown timer 
        
        Console.WriteLine("enter the starting number: ");
        int start = int.Parse(Console.ReadLine());


        for (int i = start; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("liftoff ");

    }
}