namespace task5;

class Program
{
    static void Main(string[] args)
    {
        //task1 personalized welcome function 
        //function with one parameter and no return value 

        static void PrintWelcome(string name)
        {
            Console.WriteLine("welcome, " + name +"!");
            Console.WriteLine("we hope you have a great day ");
        }

        static void main(string[] args)
        {
            Console.Write("enter your name: ");
            string name = Console.ReadLine();
            //call the function 
            PrintWelcome(name);
        }
        
        //task2 square number function 
        //function with one int parameter and an int return value 
        static int square(int number)
        {
            return number * number;
        }

        static void main2(string[] args)
        {
            Console.Write("enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            //call the function and store the returned value 
            int result = square(number);
            
            //print the result in main 
            Console.WriteLine("the square is ; " + result);
        }
    }
}