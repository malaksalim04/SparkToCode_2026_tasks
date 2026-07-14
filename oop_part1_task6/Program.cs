namespace oop_part1_task6;

class Program
{
    static void Main(string[] args)
    {
    //parr1 create clasess   
    //class BankAccount 
       public class BankAccount
       {
           public int AccountNumber;
           public string HolderName;
           public double Balance;
           //parameterized constructor (case 16)
           public BankAccount(int accountNumber, string holderName, double balance)
           {
               AccountNumber = accountNumber;
               HolderName = holderName;
               Balance = balance;
           }
           //read only property (case18)
           public bool IsOverdrawn
           {
               get
               {
                   return Balance < 0;
               }
           }

           public void Deposit(double amount)
           {
               Balance += amount;
               SendEmail();
           }

           public void Withdraw(double amount)
           {
               if (amount <= Balance)
               {
                   Balance -= amount;
                   SendEmail();
               }
               else
               {
                   Console.WriteLine("insufficient balance ");
               }
           }

           public double CheckBalance()
           {
               Console.WriteLine("---------------------------");
               Console.WriteLine("Account number:  "+ AccountNumber);
               Console.WriteLine("Holder Name:  "+HolderName);
               Console.WriteLine("Balance : "+ Balance);
           }

           public void SendEmail()
           {
               Console.WriteLine("Email notification sent ");
           }

           
       }
}