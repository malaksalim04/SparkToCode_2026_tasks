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
        
        //task3 celsius to fahrenheit function 
        //function that converts celsius to fahrenhit 
        static double celsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        static void main3(string[] args);
        {
            Console.Write("enter the temperature in celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            
            //call the function 
            double fahrenheit = celsiusToFahrenheit(celsius);
            
            //print the result 
            Console.WriteLine("temperature in fahrenheit: " + fahrenheit);
        }
        //task4 fixed menu display function 
        //function with no parameters and no return value 
        static void displaymenu()
        {
            Console.WriteLine("----menu-------");
            Console.WriteLine("1) start");
            Console.WriteLine("2) help ");
            Console.WriteLine("3) exit");

        }

        static void main4(string[] args)
        {
            //call the function 
            displaymenu();
        }
        
        
        //task5 even or odd function 
        //function the checks ifba number is even 
        static bool iseven(int number)
        {
            return number % 2 == 0;
        }

        static void main5(string[] args)
        {
            Console.Write("enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            //call the function 
            bool result = iseven(number);
            
            //use the returned value in an if else statement 

            if (result)
            {
                Console.WriteLine("Even ");
            }
            else
            {
                Console.WriteLine("Odd ");
            }
        }
    }
}