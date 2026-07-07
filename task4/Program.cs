namespace task4;

class Program
{
    static void Main(string[] args)
    {
        //task1 fixed grades array 
        int[] grades = new int[5];
        //input grades using a for loop 
        for (int i = 0; i < grades.Length; i++)
        {
            Console.Write("enter grade " + (i + 1) + ": ");
            grades[i] = Convert.ToInt32(Console.ReadLine());
        }
        //print grades using a foreach loop
        Console.WriteLine("\nStudent Grades: ");
        foreach (int grade in grades)
        {
            Console.WriteLine(grade);
        }
    }
}