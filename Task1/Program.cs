namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        // task1 personal info card 
        string name = "Sara";
        int age = 21;
        double height = 1.65;
        bool student = true;
        
        Console.Write("Name :" + name+", Age :"+age+", Height :"+ height+", Student :" +student  );

        
        // task 2 rectangle calculator 
        Console.WriteLine("enter the lenght : ");
        float length = float.Parse(Console.ReadLine());
        
        Console.WriteLine("enter the width : ");
        float width = float.Parse(Console.ReadLine());

        float area = length * width;
        float perimeter = 2 * (length + width);
        
        Console.WriteLine("the area is : " +area);
        Console.WriteLine("the perimeter is : " +perimeter);
        
        //task3 even or odd number 
        Console.Write("please Enter a whole number: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.Write("the number is even ");
        }
        else
        {
            Console.Write("the number is odd ");
        }
        
        // task4 voting eligibility
        Console.Write("enter your age : ");
        int Age = int.Parse(Console.ReadLine());
        
        Console.Write("do you have a valid ID ? : ");
        bool validID = bool.Parse(Console.ReadLine());

        if (validID == "true")
        {
            Console.Write("you have a valid ID ");
            
        }
        else
        {
            Console.Write("your ID is not valid ");
        }

        if (Age >= 18)
        {
            Console.Write("you are eligible to vote ");
        }
        else
        {
            Console.Write("you are not eligible to vote");
            
        }
        
        //task5 grade letter lookup 
        Console.WriteLine("enter your grade: ");
        string grade = Console.ReadLine();
        if (grade == "A")
        {
            Console.Write("Excellent ");
        }
        else if (grade == "B")
        {
            Console.Write("Very Good ");
        }
        else if (grade == "C")
        {
            Console.Write("Good");
        }
        else if (grade == "D")
        {
            Console.Write("Pass");
        }
        else if (grade == "F")
        {
            Console.Write("Fail");
        }
        else
        {
            Console.Write("Invalid grade");
        }
        
        // task6 temperature converter 
        Console.WriteLine("enter the  temperature in celsius : ");
        float celsius = float.Parse(Console.ReadLine());

        float fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine("the temperature is " +fahrenheit);

        if (celsius < 10)
        {
            Console.WriteLine("weather is cold ");
        }
        else if (celsius <= 30)
        {
            Console.WriteLine("weather is mild  ");
        }
        else
        {
            Console.WriteLine("weather is hot ");
        }
        //task7 movie ticket pricing 
        Console.Write("enter your age : ");
        int userage = int.Parse(Console.ReadLine());

        if (userage >= 0 && userage <= 12)
        {
            Console.WriteLine("child price: 2.000 OMR");
        }
        else if (userage >= 13 && userage <=59)
        {
            Console.WriteLine("adults price: 5.000 OMR");
        }
        else
        {
            Console.WriteLine("seniors  price: 3.000 OMR");
        }
    }
}