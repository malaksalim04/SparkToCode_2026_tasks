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
        
        //task6 rectangle area & perimeter functions 
        //function to calculate the area
        static double calculateArea(double length, double width)
        {
            return length * width;
        }
        //function to calculate the perimeter
        static double calculatePerimeter(double length, double width)
        {
            return 2 * (length + width);
        }

        static void main6(string[] args)
        {
            Console.Write("enter the length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("enter the width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            
            //call the function 
            double area = calculateArea(length, width);
            double perimeter = calculatePerimeter(length, width);
            
            //print the result 
            Console.WriteLine("area: " + area);
            Console.WriteLine("perimeter: " + perimeter);
            
        }
        
        //task7 grade letter function
        //function that return thr grade letter
        static string getGradeletter(int score)
        {
            if (score >= 90)
            {
                return "A";
            }
            else if (score >= 80)
            {
                return "B";
            }
            else if (score >= 70)
            {
                return "C";
            }
            else if (score >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        static void main7(string[] args)
        {
            Console.Write("enter your score: ");
            int score = Convert.ToInt32(Console.ReadLine());
            
            //call the function 
            string grade = getGradeletter(score);
            
            //print the returned grade
            Console.WriteLine("grade: " +grade);
        }
        
        
        //task8 countdown function 
        //function that prints a countdown 
        static void countdown(int start)
        {
            for (int i = start; i >= 1; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void main8(string[] atgs)
        {
            Console.Write("enter the starting number: ");
            int start = Convert.ToInt32(Console.ReadLine());
            
            //call the function 
            countdown(start);
        }
        //task9 overloaded multiply function 
        //overload 1: two int parameters
        static int multiply(int a, int b)
        {
            return a * b;
        }
        //overload 2 : two double parameters 
        static double multiply(double a, double b)
        {
            return a * b;
        }
        //overload 3: three int parameters 
        static int multiply(int a, int b, int c)
        {
            return a * b * c;
        }

        static void main9(string[] args)
        {
            //call all three overloaded functions 
            int result1 = multiply(4, 5);
            double result2 = multiply(2.5, 3.2);
            int result3 = multiply(2, 3, 4);
            
            //print the results
            Console.WriteLine("multiply(int, int): " + result1);
            Console.WriteLine("multiply(double, double): " + result2);
            Console.WriteLine("multiply(int, int, int): " + result3);

        }
        
        //task10 overloaded area calculator 
        //overload for a square
        static double calculateArea(double side)
        {
            return side * side;
        }
        //overload for a rectangle
        static double calculateArea(double length, double width)
        {
            return length * width;
        }

        static void main10(string[] args)
        {
            Console.WriteLine("choose a shape: ");
            Console.WriteLine("1. square");
            Console.WriteLine("2. rectangle");
            Console.WriteLine("enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("enter the side of the square: ");
                double side = Convert.ToDouble(Console.ReadLine());

                double area = calculateArea(side);
                Console.WriteLine("Area of the square: " + area);
            }
            else if (choice == 2)
            {
                Console.Write("enter the length of the rectangle: ");
                double length = Convert.ToDouble(Console.ReadLine());
                
                Console.Write("enter the width of the rectangle: ");
                double width = Convert.ToDouble(Console.ReadLine());

                double area = calculateArea(length, width);
                Console.WriteLine("area of the rectangle: "+ area);
                
            }
            else
            {
                Console.WriteLine("invalid choice ");
            }

        }
        
        //task11 function-based calculator 
        //add 
        static double add(double num1, double num2)
        {
            return num1 + num2;
        }
        //subtract 
        static double subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        //multiply 
        static double multiplynumbers(double num1, double num2)
        {
            return num1 * num2;
        }
        //divide 
        static double divide(double num1, double num2)
        {
            try
            {
                if (num2 == 0)
                {
                    throw new DivideByZeroException();
                }

                return num1 / num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("error: cannot divide by zero.");
                return 0;
            }
        }
        //display result 
        static void displayresult(string operation, double result)
        {
            Console.WriteLine(operation + "result = " + result);
        }

        static void main11(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n===== calculator menu ====");
                Console.WriteLine("1. add ");
                Console.WriteLine("2. subtract ");
                Console.WriteLine("3. multiply ");
                Console.WriteLine("4. divide ");
                Console.WriteLine("5. exit ");
                Console.WriteLine("enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 5)
                {
                    exit = true;
                    Console.WriteLine("goodbye");
                }
                else
                {
                    Console.Write("enter first number: ");
                    double num1 = Convert.ToInt32(Console.ReadLine());
                    
                    Console.Write("enter second  number: ");
                    double num2 = Convert.ToInt32(Console.ReadLine());

                    double result = 0;
                    switch (choice)
                    {
                        case 1 :
                            result = add(num1, num2);
                            displayresult("addition" ,result);
                            break;
                        case 2:
                            result = subtract(num1, num2);
                            displayresult("subtraction", result);
                            break;
                        case 3:
                            result = multiply(num1, num2);
                            displayresult("multiplication", result);
                            break;
                        case 4:
                            result = divide(num1, num2);
                            displayresult("division", result);
                            break;
                        default:
                            Console.WriteLine("invalid choice.");
                            break;
                    }
                }
                
            }
        }
    }
}