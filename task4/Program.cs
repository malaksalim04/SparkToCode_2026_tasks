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
          
          
         //task4 customer service queue
         Queue<string> customers = new Queue<string>();
         
            //enter 3 customer names 
            for (int i = 0; i < 3; i++)
            {
                Console.Write("enter customer " + (i +1 )+": ");
                customers.Enqueue(Console.ReadLine());
            }
            //serve the first customer
            string servedCustomer = customers.Dequeue();
            Console.WriteLine("served Customer: " + servedCustomer);
            
            
        //task5 array grade range 
        int[] grades = new int[5];
        int sum = 0;
          //input 5 grades
          for (int i = 0; i < grades.Length; i++)
          {
              Console.Write("enter grade " + (i + 1) + ": ");
              grades[i] = Convert.ToInt32(Console.ReadLine());
          }
          //sort the array 
          Array.Sort(grades);
          //calculate the sum 
          for (int i = 0; i < grades.Length; i++)
          {
              sum += grades[i];
          }

          double average = (double)sum / grades.Length;
          
          //display results
          Console.WriteLine("lowest grade: " + grades[0]);
          Console.WriteLine("highest grade: " + grades[grades.Length - 1]);
          Console.WriteLine("average grade: " + average);
     //task6 filtered shopping list 

     List<string> shoppingList = new List<string>();
     string item = "";
        //add items until the user types "done"
        while (item.ToLower() != "done")
        {
            Console.Write("enter an item (or type 'done' to finish):");
            item = Console.ReadLine();

            if (item.ToLower() != "done")
            {
                shoppingList.Add(item);
            }
        }
        //print the list before removal
        Console.WriteLine("\nShopping List Before Removal: ");
        foreach (string produtc in shoppingList)
        {
            Console.WriteLine("- " +produtc);
        }
        //remove an item 
        Console.WriteLine("\nEnter an item To Remove: ");
        string removeItem = Console.ReadLine();
        shoppingList.Remove(removeItem);
        
        //print the list after removal
        Console.WriteLine("\nShopping List After Removal: ");
        foreach (string product in shoppingList)
        {
            Console.WriteLine("- " + product);
        }
//task7 high podium 

        List<int> scores = new List<int>();
        //enter 5 game scores 
        for (int i = 0; i < 5; i++)
        {
            Console.Write("enter score " + (i + 1) + ": ");
            scores.Add(Convert.ToInt32(Console.ReadLine()));
        }
        //sort in ascending order
        scores.Sort();
        //revers to descending order
        scores.Reverse();
        //print the 3 scores
        Console.WriteLine("\nTop 3 Scores:");
        Console.WriteLine("1st place : " + scores[0]);
        Console.WriteLine("2nd place :"+ scores[1]);
        Console.WriteLine("3rd place :"+ scores[2]);

//task8 undo last action 
        Stack<string> actions = new Stack<string>();
        string action = "";
        //enter actions until user types "stop" 
        while (action.ToLower() !="stop")
        {
            Console.Write("enter an action (or type 'stop' to finish):");
            action = Console.ReadLine();

            if (action.ToLower() != "stop")
            {
                actions.Push(action);
            }
        }
        //undo twice
        Console.WriteLine("\nUndo 1 : " + actions.Pop());
        Console.WriteLine("undo 2: " + actions.Pop());
        
        //print remaining actions 
        Console.WriteLine("\nRemaining Actions:");

        foreach (string item in actions )
        {
            Console.WriteLine(item);
        }
    }
}