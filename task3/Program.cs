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
        
        //task2 power & root explorer
        Console.Write("enter a number: ");
        double num3 = Convert.ToDouble(Console.ReadLine());

        double square = Math.Pow(num3, 2);
        double squareroot = Math.Sqrt(num3);
        Console.WriteLine("square: " + square);
        Console.WriteLine("square root : " + squareroot);
        
        //task3 name formatter
        Console.Write("enter full mame:");
        string fullname = Console.ReadLine();
        
        Console.WriteLine("uppercase: " + fullname.ToUpper());
        Console.WriteLine("lowercase: " + fullname.ToLower());
        Console.WriteLine("number of characters: " + fullname.Length);
        
        //task4 subscription end date 
        Console.Write("enter the number of days for the free trial: ");
        int days = int.Parse(Console.ReadLine());

        DateTime today = DateTime.Today;
        DateTime enddate = today.AddDays(days);
        
        Console.WriteLine("trial end date: " + enddate.ToString("yy-MM-dd"));
        //task5 grade rounding system 
        Console.Write("enter your exam score: ");
        double examscore = double.Parse(Console.ReadLine());

        double roundedscore = Math.Round(examscore, 0);
        Console.WriteLine("rounded score: " + roundedscore);

        if (roundedscore >= 60)
        {
            Console.WriteLine("result: pass");
        }
        else
        {
            Console.WriteLine("result: faoil");
        }
        //task6 password strength checker 
        Console.Write("enter a password: ");
        string password = Console.ReadLine();

        if (password.Length >= 8 && !password.ToLower().Contains("password"))
        {
            Console.WriteLine("password strength: strong");
        }
        else
        {
            Console.WriteLine("password strength: weak");

            if (password.Length < 8)
            {
                Console.WriteLine("reason: password must be at least 8 characters long");
            }

            if (password.ToLower().Contains("password"))
            {
                Console.WriteLine("reason: password must not contain the word password ");
            }
        }


        //task7 clean name comparator 
        Console.Write("enter the first name: ");
        string name1 = Console.ReadLine();
        
        Console.Write("enter the second name: ");
        string name2 = Console.ReadLine();

        name1 = name1.Trim().ToUpper();
        name2 = name2.Trim().ToUpper();

        if (name1 == name2)
        {
            Console.WriteLine("match");
        }
        else
        {
            Console.WriteLine("not a match");
        }

        //task8 membership expiry checker
        try
        {
            Console.Write("enter membership start date (yyyy/mm/dd): ");
            DateTime startDate = DateTime.Parse(Console.ReadLine());

            Console.Write("enter the number of valid membership days: ");
            int day = int.Parse(Console.ReadLine());

            DateTime expirydate = startDate.AddDays(day);
            Console.WriteLine("expiry date: " + expirydate.ToString("yyyy-MM-dd"));
            if (expirydate >= DateTime.Today)
            {
                Console.WriteLine("membership status: active");
            }
            else
            {
                Console.WriteLine("membership status: expired");
            }
        }
        catch
        {
            Console.WriteLine("invalid date or number entered");
        }
        //task9 round up / round down explorer
        Console.Write("enter a decimal number: ");
        double number = double.Parse(Console.ReadLine());

        double nearest = Math.Round(number);
        double roundedup = Math.Ceiling(number);
        double roundedDown = Math.Floor(number);
        
        Console.WriteLine("nearest whole number: " + nearest);
        Console.WriteLine("always rounded up : " + roundedup);
        Console.WriteLine("always rounded Down: " + roundedDown);

        //task10 word position finder
        Console.Write("enter a full sentence: ");
        string sentence = Console.ReadLine();
        
        Console.Write("enter a word to search for: ");
        string word = Console.ReadLine();

        int firstPositon = sentence.IndexOf(word);
        int lastPosition = sentence.LastIndexOf(word);

        if (firstPositon == -1)
        {
            Console.WriteLine("word not found ");
        }
        else
        {
            Console.WriteLine("first occurrence position: " + firstPositon);
            Console.WriteLine("last occurrence position: " + lastPosition);
        }

    }
}