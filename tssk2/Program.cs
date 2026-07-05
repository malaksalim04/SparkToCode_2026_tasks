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
//task2 sum of numbers 1 to n 

        int n;
        int sum = 0;
        
        Console.Write("enter a number :");
        n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            sum = sum + i;
        }
        Console.WriteLine("the sum is :"+ sum );
//task3 multiplication table 
        
        int number;
        Console.Write("enter a number: ");
        number = int.Parse(Console.ReadLine());
        
        for (int i =1; i<= 10; i++)
        {
            Console.WriteLine(number +"x"+i+"="+(number*i));
        }
    }
}