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
        //task4 password retry

        string password = "spark2026";
        string input = "";
        while (input != password)
        {
            Console.Write("enter the password : ");
            input = Console.ReadLine();

            if (input != password)
            {
                Console.WriteLine("incorrect password try again ");
            }
        }
        Console.WriteLine("access granted ");
        // task5 number guessing game 

        int secretnumber = 42;
        int guess;
        int attempts = 0;

        do
        {
            Console.Write("enter your guess: ");
            guess = int.Parse(Console.ReadLine());

            attempts++;
            if (guess > secretnumber)
            {
                Console.WriteLine("too high");
            }
            else if (guess < secretnumber)
            {
                Console.WriteLine("too low ");
            }
            else
            {
                Console.WriteLine("correct ");
            }

        }
        while (guess != secretnumber);
        Console.WriteLine("it took you " + attempts +"attempts");
// task6 safe division calculator 

        try
        {
            Console.Write("enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 / num2;
            Console.WriteLine("result : " + result);

        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("you cannot divide by zero");
        }
        catch (FormatException)
        {
            Console.WriteLine("enter a valid number ");
        }
        
        // task7 repeating menu with exit option

        int choice = 0;
        while (choice != 3)
            
        {
            Console.WriteLine("menu");
            Console.WriteLine("1. say hello");
            Console.WriteLine("2. show current time-of day ");
            Console.WriteLine("3.exit");
            Console.WriteLine("enter your choice : ");

            try
            {
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("hello");
                        break;
                    case 2:
                        Console.WriteLine("good morning ");
                        break;
                    case 3:
                        Console.WriteLine("exiting program ");
                        break;
                    default:
                        Console.WriteLine("invalid choice ");
                        break;
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("pleas enter a valid number ");
               
            }
            
        }
    }
}