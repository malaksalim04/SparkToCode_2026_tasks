using System.ComponentModel.Design;

namespace oop_part1_task6;

class Program
{
    static void Main(string[] args)
    {
        //parr1 create clasess   
        //class BankAccount 
        class
        BankAccount
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
        get { return Balance < 0; }
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
        PrintInformation();
        return Balance;
    }

    private void PrintInformation()
    {
        Console.WriteLine("---------------------------");
        Console.WriteLine("Account number:  " + AccountNumber);
        Console.WriteLine("Holder Name:  " + HolderName);
        Console.WriteLine("Balance : " + Balance);
    }

    private void SendEmail()
    {
        Console.WriteLine("Email notification sent ");
    }
}

class Student
           {
               public string Name;
               public string Address;
               public int Grade;
               
               private string email;
               int age;

               // Total Students Counter [Static Fields & Methods]  case 17 
               private static int totalStudents = 0;

               //write only property (case 19)

               private string pin;

               public string PIN
               {
                   set
                   {
                       pin = value;
                   }
               }


               public Student()
               {
                   totalStudents++;
               }

               public static int GetStudentcount()
               {
                   return totalStudents;
               }

               public void Register(string Email)
               {
                   email = Email;
                   SendEmail();
               }

               private void SendEmail()
               {
                   Console.WriteLine("Registration Email sent ");
               }
           }

        class Product
               {
                   public string ProductName;
                   public double Price;
                   public int StockQuantity;

                   public void Sell(int quantity)
                   {
                       if (quantity <= StockQuantity)
                       {
                           StockQuantity -= quantity;
                       }
                       else
                       {
                           Console.WriteLine("not enough stock");
                       }

                       LogTransaction();
                   }

                   public void Restock(int quantity)
                   {
                       StockQuantity += quantity;
                       LogTransaction();
                   }

                   public double GetInventoryValue()
                   {
                       PrintDetails();
                       return Price * StockQuantity;
                   }
                   
                   private void PrintDetails()
                   {
                       Console.WriteLine("===================");
                       Console.WriteLine("Product : " + ProductName);
                       Console.WriteLine("price : " + Price);
                       Console.WriteLine("Stock : " + StockQuantity);

                   }

                   private void LogTransaction()
                   {
                       Console.WriteLine("Transaction logged ");
                   }
               }

               class program
               {
                    static BankAccount acccount1 = new BankAccount();
                    static BankAccount acccount2 = new BankAccount();

                    static Student student1 = new Student();
                    static Student student2 = new Student();

                    static product product1 = new Product();
                    static product product2 = new Product();

                    static void Main(string[] args)
                    {
                        //Bank Accounts 
                        acccount1.AccountNumber = 1163;
                        acccount1.HolderName = "karim";
                        acccount1.Balance = 120;

                        acccount2.AccountNumber = 15203;
                        acccount2.HolderName = "Ali";
                        acccount2.Grade = 70;
                        
                        //Students
                        student1.Name = "Ali";
                        student1.Address = "Muscat";
                        student1.Grade = 65;
                        
                        student2.Name = "Ahmed";
                        student2.Address = "Muscat";
                        student2.Grade = 70;
                        
                        
                        // products 
                        product1.ProductName = "Wireless Mouse";
                        product1.Price = 5.500;
                        product1.StockQuantity = 50;
                        
                        product2.ProductName = "Mechanical Keyboard";
                        product2.Price = 15.750;
                        product2.StockQuantity = 20;

                        while (true)
                        {
                            Console.Clear();
                            
                            Console.WriteLine("==========BANK & STUDENT MANAGEMANT ======");
                            Console.WriteLine("1. View Account Details ");
                            Console.WriteLine("2. Update Student Address");
                            Console.WriteLine("3. Deposit ");
                            Console.WriteLine("4. Withdraw");
                            Console.WriteLine("5. View Product");
                            Console.WriteLine("6. Register student ");
                            Console.WriteLine("7. Compare Accounts ");
                            Console.WriteLine("8. Restock Product");
                            Console.WriteLine("9. Transfer Between accounts");
                            Console.WriteLine("10. Update Student Grade ");
                            Console.WriteLine("11. Student Report ");
                            Console.WriteLine("12. Account Status");
                            Console.WriteLine("13. sell Product ");
                            Console.WriteLine("14. scholarship Eligibility ");
                            Console.WriteLine("15. Balance Top-Up ");
                            Console.WriteLine("16. Quick Account Opening ");
                            Console.WriteLine("17. Total Students");
                            Console.WriteLine("18. Overdrawn Check");
                            Console.WriteLine("19. Set Student PIN");
                            Console.WriteLine("20. Exit ");
                            Console.Write("\nChoose: ");

                            int choice;
                            try
                            {
                                choice = int.Parse(Console.ReadLine());
                            }
                            catch 
                            {
                                Console.WriteLine("Invalid Input");
                                Console.ReadLine();
                                continue;
                            }

                            switch (choice)
                            {
                                case 1:
                                    ViewAccount();
                                    break;
                                case 2:
                                    UpdateAddress();
                                    break;
                                case 3:
                                    DepositMoney();
                                    break;
                                case 4:
                                    WithdrawMoney();
                                    break;
                                case 5:
                                    ViewProduct();
                                    break;
                                case 6:
                                    RegisterStudent();
                                    break;
                                case 7:
                                    CompareAccounts();
                                    break;
                                case 8:
                                    RegisterProduct();
                                    break;
                                case 9:
                                    Transfermoney();
                                    break;
                                case 10:
                                    UpdateGrade();
                                    break;
                                case 11 ;
                                    StudentReport();
                                    break;
                                case 12:
                                    AccountStatus();
                                    break;
                                case 13:
                                    SellProduct();
                                    break;
                                case 14 :
                                    Scholarship();
                                    break;
                                case 15:
                                    TopUP();
                                    break;
                                    
                                default:
                                    Console.WriteLine("coming in the next part ........");
                                    break;
                            }
                            Console.WriteLine("\nPress Enter......");
                            Console.ReadLine();
                        }
                    }
                    
                
               //case 1 View Account Details

               static void ViewAccount()
               {
                   Console.Write("chose Account (1 or 2 ): ");
                   int choice = int.Parse(Console.ReadLine());

                   if (choice == 1)
                   {
                       account1.CheckBalance();
                   }
                   else if (choice == 2 )
                   {
                       account2.CheckBalance();
                   }
                   else
                   {
                       Console.WriteLine("Invalid Account ");
                   }
               }
               //case 2   Update Student Address

               static void UpdateAddress()
               {
                   Console.Write("Chose Student (1 or 2 ) : ");
                   int choice = int.Parse(Console.ReadLine());
                   
                   Console.Write("Enter New Address: ");
                   string address = Console.ReadLine();

                   if (choice == 1)
                   {
                       student1.Address = address;
                       Console.WriteLine("Address Update Successfully ");
                       Console.WriteLine("New address: " + student1.Address);
                   }
                   else if (choice == 2)
                   {
                       student2.Address = address;
                       Console.WriteLine("Address Updated Successfully ");
                       Console.WriteLine("New address: " +student2.Address);
                   }
                   else
                   {
                       Console.WriteLine("invalid Student ");
                   }
               }
               
               // case 3 Make a Deposit
               static void DepositMoney()
               {
                   Console.Write("chose Account (1 or 2 ) : ");
                   int choice = int.Parse(Console.ReadLine());

                   Console.Write("enter Deposit Amount: ");
                   double amount = double.Parse(Console.ReadLine());

                   if (choice == 1)
                   {
                       account1.Deposit(amount);
                       Console.WriteLine(account1.HolderName + "'s New Balance = " + account1.Balance);
                   }
                   else if (choice == 2)
                   {
                       account2.Deposit(amount);
                       Console.WriteLine(account2.HolderName + "'s New Balance = " + account2.Balance);
                   }
                   else
                   {
                       Console.WriteLine("Invalid account ");
                   }
               }

               //case4  Make a Withdrawal
                   static void WithdrawMoney()
                   {
                       Console.Write("chose Account (1 or 2 ) : ");
                       int choice = int.Parse(Console.ReadLine());
                       
                       Console.Write("enter Withdrawal Amount: ");
                       double amount = double.Parse(Console.ReadLine());

                       if (choice == 1)
                       {
                           account1.Withdraw(amount);
                           Console.WriteLine("Current Balance = " + account1.Balance);
                       }
                       else if (choice == 2)
                       {
                           account1.Withdraw(amount);
                           Console.WriteLine("Current Balance = " + account2.Balance);
                       }
                       else
                       {
                           Console.WriteLine("Invalid Account ");
                       }
                   }
                   
                   //case 5 View Product Details
                   static void ViewProduct()
                   {
                       Console.Write("choose product ( 1 or 2): ");
                       int choice = int.Parse(Console.ReadLine());

                       if (choice == 1)
                       {
                           double value = Product1.GetInventoryValue();
                           Console.WriteLine("Inventory Value = " + value);
                       }
                       else if (choice == 2)
                       {
                           double value = Product2.GetInventoryValue();
                           Console.WriteLine("Inventory Value = " + value);
                       }
                       else
                       {
                           Console.WriteLine("Invalid Product");
                       }
                   }
                   //case 6 Register a Student
                   static void RegisterStudent()
                   {
                       Console.Write("Choose student (1 or 2): ");
                       int choice = int.Parse(Console.ReadLine());
                       
                       Console.Write("Enter Email: ");
                       string email = Console.ReadLine();

                       if (choice ==1 )
                       {
                           student1.Register(email);
                           Console.WriteLine("student registered successfully");
                       }
                       else if (choice == 2)
                       {
                           student2.Register(email);
                           Console.WriteLine("student registered successfully");
                       }
                       else
                       {
                           Console.WriteLine("Invalid Student ");
                       }
                   }
                   //case 7 Compare Two Account Balances
                   static void CompareAccounts()
                   {
                       if (account1.Balance > account2.Balance)
                       {
                           Console.WriteLine(account1.HolderName + "has more money");
                       }
                       else if (account2.Balance > account1.Balance)
                       {
                           Console.WriteLine(account2.HolderName + "has more money ");
                       }
                       else
                       {
                           Console.WriteLine("both accounts have the same balance ");
                       }
                   }
                   //case 8 Restock Product & Stock Level Check
                   static void RestockProduct()
                   {
                       Console.Write("Choose Product (1 or 2): ");
                       int choice = int.Parse(Console.ReadLine());
                       
                       Console.Write("Quantity to Add: ");
                       int quantity = int.Parse(Console.ReadLine());

                       Product selected = null;

                       if (choice == 1)
                       {
                           selected = product1;
                       }
                       else if (choice == 2)
                       {
                           selected = product2;
                       }
                       else
                       {
                           Console.WriteLine("Invalid product ");
                           return;
                       }
                       
                       selected.Restock(quantity);
                       Console.WriteLine("Current Stock = " + selected.StockQuantity);

                       if (selected.StockQuantity < 10)
                       {
                           Console.WriteLine("Stock Level : Low ");
                       }
                       else if (selected.StockQuantity < 50)
                       {
                           Console.WriteLine("Stock Level : Moderate ");
                       }
                       else
                       {
                           Console.WriteLine("Stock Level: Well Stocked");
                       }
                       
                       
                       // case 9 Transfer Between Accounts
                       static void TransferMoney()
                       {
                           Console.WriteLine("Transfer From Account (1 or 2 ): ");
                           int from = int.Parse(Console.ReadLine());
                           
                           Console.WriteLine("Transfer To Account (1 or 2 ): ");
                           int to = int.Parse(Console.ReadLine());

                           if (from == to)
                           {
                               Console.Write("cannot transfer to the same account ");
                               return;
                           }

                           BankAccount source = null;
                           BankAccount destination = null;

                           if (from == 1)
                               source = account1;
                           else if (from == 2)
                               source = account2;

                           if (to == 1)
                               destination = account1;
                           else if (to == 2)
                               destination = account2;

                           if (source == null || destination == null)
                           {
                               Console.WriteLine("Invalid account ");
                               return;
                           }
                           Console.Write("Amount: ");
                           double amount = double.Parse(Console.ReadLine());

                           if (source.Balance >= amount)
                           {
                               source.Withdraw(amount);
                               destination.Deposit(amount);
                               
                               Console.WriteLine("Transfer completed ");
                           }
                           else
                           {
                               Console.WriteLine("Transfer failed not enough balance");
                           }
                       }
                       
                       //case 10  Update Student Grade (Validated)
                       static void UpdateGrade()
                       {
                           Console.Write("choose student ( 1 or 2): ");
                           int choice = int.Parse(Console.ReadLine());
                           
                           Console.WriteLine("enter new grade: ");

                           try
                           {
                               int grade = int.Parse(Console.ReadLine());

                               if (grade < 0 || grade > 100)
                               {
                                   Console.WriteLine("Grade must be between 0 and 100");
                                   return;
                               }
                               else if (choice == 1)
                               {
                                   student1.Grade = grade;
                                   Console.WriteLine("Grade Updated");
                               }
                               else if (choice == 2)
                               {
                                   student2.Grade = grade;
                                   Console.WriteLine("Grade updated ");
                               }
                               else
                               {
                                   Console.WriteLine("Invalid Student ");
                               }
                           }
                           catch 
                           {
                               Console.WriteLine("Invalid grade ");
                           }
                       }

                       static void StudentReport()
                       {
                           student selected:
                           
                           Console.Write("choose student ( 1 or 2): ");
                           int choice = int.Parse(Console.ReadLine());

                           if (choice == 1)
                               selected = student1;
                           else if (choice == 2)
                               selected = student2;
                           else
                           {
                               Console.WriteLine("Invalid Student ");
                               return;
                           }
                           Console.WriteLine("\n===== Student Report========");
                           Console.WriteLine("Name: " + selected.Name);
                           Console.WriteLine("Address: " + selected.Address);
                           Console.WriteLine("Grade: " + selected.Grade);
                           
                           if(selected.Grade >= 60)
                               Console.WriteLine("Result: pass");
                           else
                           {
                               Console.WriteLine("Result: Fail");
                           }
                           
                       }

                       static void AccountStatus()
                       {
                           BankAccount selected;
                           
                           Console.Write("choose Account ( 1 or 2) : ");
                           int choice = int.Parse(Console.ReadLine());

                           if (choice == 1)
                           {
                               selected = acccount1;
                           }
                           else if (choice == 2)
                           {
                               selected = acccount2;
                           }
                           else
                           {
                               Console.WriteLine("Invalid account ");
                               return;
                           }
                           
                           Console.WriteLine("Current Balance = " + selected.Balance);

                           if (selected.Balance < 50)
                           {
                               Console.WriteLine("Status: low Balance");
                           }
                           else if (selected.Balance <= 1000)
                           {
                               Console.WriteLine("Status: Healthy");
                           }
                           else
                           {
                               Console.WriteLine("Status: Premium");
                           }
                       }
                       
                       //Case 13 - Bulk Sale With Revenue Calculation
                       static void sellProduct()
                       {
                           Product selected;
                           
                           Console.Write("Choose Product (1 or 2): ");
                           int choice = int.Parse(Console.ReadLine());

                           if (choice == 1)
                           {
                               selected = product1;
                           }
                           else if (choice == 2)
                           {
                               selected = product2;
                           }
                           else
                           {
                               Console.WriteLine("Invalid Product");
                               return;
                           }
                           
                           Console.Write("Quantity to Sell: ");
                           int quantity = int.Parse(Console.ReadLine());

                           if (selected.StockQuantity < quantity)
                           {
                               Console.WriteLine("Need" + (quantity - selected.StockQuantity) + "more items ");
                           }
                           else
                           {
                               selected.Sell(quantity);
                               double revenue = quantity * selected.Price;
                               Console.WriteLine("revenue = " + revenue);
                           }
                       }
                       //Case 14 - Scholarship Eligibility Check
                       Console.Write("choose Student  (1 or 2): ");
                       int s = int.Parse(Console.ReadLine());
                       
                       Console.Write("choose Account (1 or 2) : ");
                       int a = int.Parse(Console.ReadLine());

                       Student student = (s == 1) ? student1 : student2;
                       BankAccount account = (a == 1) ? acccount1 : acccount2;

                       if (student.Grade >= 80 && account.Balance >= 100)
                       {
                           Console.WriteLine("Eligible");
                       }
                       else
                       {
                           Console.WriteLine("Not Eligible ");
                           
                           if (student.Grade < 80 )
                              Console.WriteLine("Grade is too low "); 
                       }

                   }
                  // Case 15 - Full Balance Top-Up Flow
                  static void TopUP()
                  {
                      BankAccount selected;
                      
                      Console.Write("choose account (1 or 2 ) : ");
                      int choice = int.Parse(Console.ReadLine());

                      if (choice == 1)
                      {
                          selected = acccount1;
                      }
                      else if (choice == 2)
                      {
                          selected = acccount2;
                      }
                      else
                      {
                          Console.WriteLine("Invalid account ");
                          return;
                      }

                      double before = selected.Balance;

                      if (before < 50)
                      {
                          double amount = 100 - before;
                          selected.Deposit(amount);
                          
                          Console.WriteLine("Balance Before = " + before);
                          Console.WriteLine("Balance after = " + selected.Balance);
                      }
                      else
                      {
                          Console.WriteLine("No Top-Up Needed");
                      }
                  }
                  
                  
               }
           }
}