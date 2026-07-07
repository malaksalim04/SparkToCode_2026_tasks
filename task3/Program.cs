namespace task3;

class Program
{
    static void Main(string[] args)
    {
        //task1 absolute difference 
        Console.Write("enter the frist number: ");
        double num1 = double.Parse(Console.ReadLine());
        
        Console.Write("enter the seconsd number: ");
        double num2 = double.Parse(Console.ReadLine());

        double difference = Math.Abs(num1 - num2);
        
        Console.WriteLine("positive difference: " +difference);
        
    }
}