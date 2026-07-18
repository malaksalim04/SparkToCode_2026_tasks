using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_Part2;

class Program
{
    static void Main(string[] args)
    {
        List<Room> rooms = new List<Room>();
        List<Guest> guests = new List<Guest>();
       
        
        rooms.Add(new Room(101, "Single",25,true));
        rooms.Add(new Room(102, "Single",30,true));
        rooms.Add(new Room(201, "Double",45,true));
        rooms.Add(new Room(202, "Double",50,true));
        rooms.Add(new Room(301, "Suite",80,true));
        rooms.Add(new Room(302, "Suite",100,true));


        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            
            Console.WriteLine("**********************************************");
            Console.WriteLine("GRAND VISTA HOTEL — MANAGEMENT SYSTEM");
            Console.WriteLine(" 1. Add New Room");
            Console.WriteLine(" 2. Register New Guest");
            Console.WriteLine(" 3. Book a Room for a Guest");
            Console.WriteLine(" 4. View All Rooms");
            Console.WriteLine(" 5. View All Guests");
            Console.WriteLine(" 6. Search & Filter Rooms");
            Console.WriteLine(" 7. Guest & Booking Statistics");
            Console.WriteLine(" 8. Update Room Price");
            Console.WriteLine(" 9. Guest Lookup by Name");
            Console.WriteLine(" 10. Room Type Breakdown Report");
            Console.WriteLine(" 11. Check Out a Guest");
            Console.WriteLine(" 12. Remove Unavailable Rooms");
            Console.WriteLine(" 13. Extend Guest Stay");
            Console.WriteLine(" 14. Highest Revenue Booking");
            Console.WriteLine(" 15. Guest Pagination Viewer");
            Console.WriteLine(" 0. Exit");
            Console.WriteLine("***************************************************");
            Console.WriteLine(" Enter your choice: ");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.Write("Invalid input . Please enter a number: ");
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Room Number: ");
                    int roomNumber;

                    while (!int.TryParse(Console.ReadLine(), out roomNumber) || roomNumber <= 0)
                    {
                        Console.WriteLine("Invalid room Number enter a positive number: ");
                    }

                    if (rooms.Any(r => r.RoomNumber == roomNumber))
                    {
                        Console.WriteLine("a room with this number already exists ");
                        break;
                    }
                    Console.Write("Enter room type (Single/Double/Suite): ");
                    string roomType = Console.ReadLine();
                    
                    Console.Write("enter price per night: ");
                    double price;

                    while (!double.TryParse(Console.ReadLine(), out price) || price <= 0 )
                    {
                        Console.Write("Invalid price enter a positive number : ");
                    }

                    Room newRoom = new Room(roomNumber, roomType, price, true);
                    
                    rooms.Add(newRoom);
                    
                    Console.WriteLine();
                    Console.WriteLine("Room added successfully");
                    Console.WriteLine("================================= ");
                    Console.WriteLine("Room Number : " + newRoom.RoomNumber);
                    Console.WriteLine("Room type : " + newRoom.RoomType);
                    Console.WriteLine("Price : " + newRoom.PricePerNight.ToString("F2"));
                    Console.WriteLine("Status : Available ");
                    Console.WriteLine("total Rooms : " + rooms.Count);
                    
                    break;
                case 2:
                    Console.WriteLine("case 2 - Register New Guest");
                    break;
                case 3:
                    Console.WriteLine("case 3 - Book a Room for a Guest");
                    break; 
                case 4:
                    Console.WriteLine("case 4 - View All Rooms");
                    break; 
                case 5:
                    Console.WriteLine("case 5 - View All Guests");
                    break; 
                case 6:
                    Console.WriteLine("case 6 -Search & Filter Rooms");
                    break; 
                case 7:
                    Console.WriteLine("case 7 - Guest & Booking Statistics");
                    break; 
                case 8:
                    Console.WriteLine("case 8 - Update Room Price");
                    break;
                case 9:
                    Console.WriteLine("case 9 - Guest Lookup by Name");
                    break;
                case 10:
                    Console.WriteLine("case 10 - Room Type Breakdown Report");
                    break;
                case 11:
                    Console.WriteLine("case 11 - Check Out a Guest");
                    break;
                case 12:
                    Console.WriteLine("case 12 -Remove Unavailable Rooms");
                    break;
                case 13:
                    Console.WriteLine("case 13 - Extend Guest Stay");
                    break;
                case 14:
                    Console.WriteLine("case 14 - Highest Revenue Booking");
                    break;
                case 15:
                    Console.WriteLine("case 15 - Guest Pagination Viewer");
                    break;
                case 0:
                    exit = true;
                    Console.WriteLine(" Thank you for using the Hotel Management System");
                    break;
                default:
                    Console.WriteLine("Invalid Choice try again ");
                    break;
            }

            if (!exit)
            {
                Console.WriteLine();
                Console.WriteLine("Press amy key to return to the menu    ");
                Console.ReadKey();
            }
        }
    }
}

class Room
{
    //room
    public int RoomNumber { get; set; }
    public string RoomType { get; set; }
    public double PricePerNight { get; set; }
    public bool IsAvailable { get; set; }

    public Room(int roomNumber, string roomType, double pricePerNight, bool isAvailable)
    {
        RoomNumber = roomNumber;
        RoomType = roomType;
        PricePerNight = pricePerNight;
        IsAvailable = isAvailable;
    }

    public void DisplayRoom()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("Room Number: " + RoomNumber);
        Console.WriteLine("Room Type: " + RoomType);
        Console.WriteLine("Price Per Night: " + PricePerNight);        
        Console.WriteLine("Available: " + IsAvailable);

    }
}

class Guest
{
    //guest
    public string GuestID;
    public string GuestName;
    public string RoomNumber;
    public string CheckInDate;
    public int TotalNights;
    public double PricePerNight;

    public Guest(string guestId, string guestName, string roomNumber, string checkInDate, int totalNights)
    {
        GuestID = guestId;
        GuestName = guestName;
        RoomNumber = roomNumber;
        CheckInDate = checkInDate;
        TotalNights = totalNights;
        PricePerNight = 0;
    }

    public void DisplayGuest()
    {
        Console.WriteLine("----------------------------");
        Console.WriteLine("Guest ID: " + GuestID);
        Console.WriteLine("Guest Name: " + GuestName);
        Console.WriteLine("Room Number: " + RoomNumber);
        Console.WriteLine("Check In Date: " + CheckInDate);
        Console.WriteLine("Total Nights: " + TotalNights);
    }

    public double CalculateTotalCost()
    {
        return PricePerNight * TotalNights;
    }
}