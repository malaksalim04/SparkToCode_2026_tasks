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
        //task2 dynamic to_do list
        List<string> tasks = new List<string>();
        //input 5 tasks 
        for (int i = 0; i < 5; i++)
        {
            Console.Write("enter task " + (i + 1) + ":");
            tasks.Add(Console.ReadLine());
        }
        //print all tasks
        Console.WriteLine("\nTo_Do List: ");

        foreach (string task in tasks )
        {
            Console.WriteLine("- " + task);
        }

        //task3 browsing history stack
        Stack<string> history = new Stack<string>();
          //enter 3 website URLs
          for (int i = 0; i < 3; i++)
          {
              Console.Write("enter website URL " + (i + 1) + ": ");
              history.Push(Console.ReadLine());
          }
          //simulate pressing the back button 
          history.Pop();
          Console.WriteLine("current page after pressing back : " + history.Peek());
    }
}