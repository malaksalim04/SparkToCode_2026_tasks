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
    }
}