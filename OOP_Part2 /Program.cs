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
                    Console.WriteLine("enter Guest name : ");
                    string guestName = Console.ReadLine();
                    
                    Console.WriteLine("enter check in date : ");
                    string checkInDate = Console.ReadLine();
                    
                    Console.WriteLine("enter number of nights : ");
                    int nights;

                    while (!int.TryParse(Console.ReadLine(), out nights) || nights <= 0)
                    {
                        Console.WriteLine("Invalid input enter a positive number: ");
                    }

                    string guestID = "G" + (guests.Count + 1).ToString("D3");
                    
                    Guest newGuest = new Guest(
                        guestID,
                        guestName,
                        "Not Assigned",
                        checkInDate,
                        nights);
                    
                    guests.Add(newGuest);
                    
                    Console.WriteLine();
                    Console.WriteLine("Guest registered successfully");
                    Console.WriteLine("==================================");
                    Console.WriteLine("Guest ID: " + newGuest.GuestID);
                    Console.WriteLine("Guest Name : " + newGuest.GuestName);
                    Console.WriteLine("Room Number : " + newGuest.RoomNumber);
                    Console.WriteLine("Check-In Date : " + newGuest.CheckInDate);
                    Console.WriteLine("Total Nights : " + newGuest.TotalNights);

                    break;
                case 3:
                    Console.Write("enter Guest ID : ");
                    string searchGuestID = Console.ReadLine();

                    Guest guest = guests.FirstOrDefault(g => g.GuestID == searchGuestID);

                    if (guest == null)
                    {
                        Console.WriteLine("guest not found ");
                        break;
                    }
                    
                    Console.WriteLine("enter room number : ");
                    int searchRoomNumber;

                    while (!int.TryParse(Console.ReadLine(), out searchRoomNumber))
                    {
                        Console.WriteLine("invalid room number try again : ");
                    }

                    Room room = rooms.FirstOrDefault(r => r.RoomNumber == searchRoomNumber);

                    if (room == null)
                    {
                        Console.WriteLine("room not found ");
                        break;
                    }

                    if (!room.IsAvailable)
                    {
                        Console.WriteLine("room is already booked ");
                        break;
                    }

                    guest.RoomNumber = room.RoomNumber.ToString();
                    guest.PricePerNight = room.PricePerNight;

                    room.IsAvailable = false;
                    
                    Console.WriteLine();
                    Console.WriteLine("booking successful ");
                    Console.WriteLine("===============================");
                    Console.WriteLine("guest name : " + guest.GuestName);
                    Console.WriteLine("room number : " + room.RoomNumber);
                    Console.WriteLine("room type : " + room.RoomType);
                    Console.WriteLine("price/night : " + room.PricePerNight.ToString("F2"));
                    Console.WriteLine("Total nights : " + guest.TotalNights);
                    Console.WriteLine("Total cost : " + guest.CalculateTotalCost().ToString("F2"));


                    break; 
                case 4:

                    if (rooms.Count() == 0)
                    {
                        Console.WriteLine("no rooms have been added yet ");
                        break;
                    }

                    Console.WriteLine();
                    Console.WriteLine("======= ALL ROOMS ============");
                    Console.WriteLine("Total Rooms: " + rooms.Count());

                    foreach (Room room in rooms.OrderBy(r => r.RoomNumber))
                    {
                        Console.WriteLine("=========================");
                        Console.WriteLine("Room Number : " + room.RoomNumber);
                        Console.WriteLine("Room Type : " + room.RoomType);
                        Console.WriteLine("Price : " + room.PricePerNight.ToString("F2") + "OMR");

                        if (room.IsAvailable)
                        {
                            Console.WriteLine("Status : Available ");
                        }
                        else
                        {
                            Console.WriteLine("status : Booked");
                        }
                    }
                    break; 
                case 5:
                    if (guests.Count() == 0)
                    {
                        Console.WriteLine("no guests have been registered yet ");
                        break;
                    }
                    
                    Console.WriteLine();
                    Console.WriteLine("====== ALL GUESTS =======");
                    Console.WriteLine("Total guests: " + guests.Count());

                    foreach (Guest guest in guests.OrderBy(g => g.GuestName))
                    {
                        Console.WriteLine("----------------");
                        Console.WriteLine("Guest ID : " + guest.GuestID);
                        Console.WriteLine("Guest Name : " + guest.GuestName);
                        Console.WriteLine("Room Number : " + guest.RoomNumber);
                        Console.WriteLine("Check-In Date : " + guest.CheckInDate);
                        Console.WriteLine("Total Nights : " + guest.TotalNights);
                    }
                    
                    break; 
                case 6:
                    Console.WriteLine("===========SEARCH & FILTER ROOMS =============");
                    Console.WriteLine("1. Show All Available Rooms ");
                    Console.WriteLine("2. Filter by Room Type ");
                    Console.WriteLine("3. Filter by Maximum Price ");
                    Console.WriteLine("4. Room Price Statistics ");
                    Console.WriteLine("0. Back ");
                    
                    Console.WriteLine("Choose an option ");

                    int option;
                    while (!int.TryParse(Console.ReadLine(), out option))
                    {
                        Console.WriteLine("Invalid input try again ");
                    }

                    switch (option)
                    {
                        case 1:
                            var availableRooms = rooms
                                .Where(r => r.IsAvailable)
                                .OrderBy(r => r.PricePerNight);
                            if (!availableRooms.Any())
                            {
                                Console.WriteLine("no rooms found for the selected criteria ");
                            }
                            else
                            {
                                Console.WriteLine("Available Rooms : " + availableRooms.Count());
                                foreach (Room room in availableRooms)
                                {
                                    Console.WriteLine("--------------------");
                                    Console.WriteLine("Room number : " + room.RoomNumber);
                                    Console.WriteLine("Room Type : " + room.RoomType);
                                    Console.WriteLine("Price: " + room.PricePerNight.ToString("F2"));
                                }
                            }
                            break;
                        case 2: 
                            Console.WriteLine("Enter room type : (Single/Double/Suite): ");
                            string roomType = Console.ReadLine();

                            var roomTypeList = rooms
                                .Where(r => r.RoomType.Equals(roomType, StringComparison.OrdinalIgnoreCase));
                            if (!roomTypeList.Any())
                            {
                                Console.WriteLine("no rooms found for the selected criteria ");
                            }
                            else
                            {
                                Console.WriteLine("Rooms found : " + roomTypeList.Count());

                                foreach (Room room in roomTypeList)
                                {
                                    Console.WriteLine("-------------");
                                    Console.WriteLine("Room Number : " + room.RoomNumber);
                                    Console.WriteLine("price : " + room.PricePerNight.ToString("f2"));
                                    Console.WriteLine("Available : " + room.IsAvailable);
                                }
                            }
                            break;

                        case 3: 
                            Console.WriteLine("enter maximum price : ");
                            double maxPrice;

                            while (!double.TryParse(Console.ReadLine(), out maxPrice))
                            {
                                Console.WriteLine("Invalid price tr again: " );
                            }

                            var affordableRooms = rooms
                                .Where(r => r.IsAvailable && r.PricePerNight <= maxPrice)
                                .OrderBy(r => r.PricePerNight);

                            if (!affordableRooms.Any())
                            {
                                Console.WriteLine("no rooms found for the selected criteria ");
                            }
                            else
                            {
                                Console.WriteLine("rooms found : " + affordableRooms.Count());
                                foreach (Room room in affordableRooms)
                                {
                                    Console.WriteLine("=============");
                                    Console.WriteLine("room number : " + room.RoomNumber);
                                    Console.WriteLine("room type : " + room.RoomType);
                                    Console.WriteLine("price : " + room.PricePerNight.ToString("F2"));
                                }
                            }
                            break;
                        case 4:
                            Console.WriteLine("=======ROOM STATISTICS ==============");
                            
                            Console.WriteLine("total rooms : " + rooms.Count());
                            Console.WriteLine("available rooms : " + rooms.Count(r => r.IsAvailable));
                            Console.WriteLine("average prices : " + rooms.Average(r => r.PricePerNight).ToString("F2"));
                            Console.WriteLine("cheapest room : " + rooms.Min(r => r.PricePerNight).ToString("F2"));
                            Console.WriteLine("most expensive : " + rooms.Max(r => r.PricePerNight).ToString("f2"));
                            break;
                        case 0:
                            break;
                        default:
                            Console.WriteLine("invalid option ");
                    }

                    break; 
                case 7:
                    Console.WriteLine("------- Guest & Booking Statistics-------");
                    //total guests 
                    Console.WriteLine("total Registered Guests : " + guests.Count());
                    //guests with booking 
                    Console.WriteLine("Guests with booking : " + guests.Count(g => g.RoomNumber !="Not Assigned"));
                    //total rooms 
                    Console.WriteLine("total rooms : " + rooms.Count());
                    //booked rooms 
                    Console.WriteLine("booked rooms: " + rooms.Count(r => !r.IsAvailable));
                    
                    //check if there are any active bookings 
                    if (!guests.Any(g => g.RoomNumber != "Not Assigned "))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("no active booking recorded ");
                        break;
                    }
                    //avrage night 
                    double averageNights = guests
                        .Where(g => g.RoomNumber != "Not assigned")
                        .Average(g => g.TotalNights);
                    
                    Console.WriteLine("average nights : " + averageNights.ToString("F2"));
                    Console.WriteLine("");
                    Console.WriteLine("======top 3  highest revenue booking =====");
                    var topGuests = guests
                        .Where(g => g.RoomNumber != "Not Assigned")
                        .OrderByDescending(g => g.CalculateTotalCost())
                        .Take(3);

                    foreach (Guest guest in topGuests)
                    {
                        Console.WriteLine("------");
                        Console.WriteLine("guest name : " + guest.GuestName);
                        Console.WriteLine("room : " +guest.RoomNumber);
                        Console.WriteLine("total cost : " + guest.CalculateTotalCost().ToString("F2") + "OMR");
                        
                    }
                    Console.WriteLine("");
                    Console.WriteLine("-----booking summary --------");

                    var summary  = guests
                        .Where(g => g.RoomNumber != "Not Assigned")
                        .Select(g =>
                            g.GuestName + " - room " + g.RoomNumber + 
                            " - " + g.TotalNights + "nights - OMR  " +
                            g.CalculateTotalCost().ToString("F2"));

                    foreach (string item in summary)
                    {
                        Console.WriteLine(item);
                    }
                    break;

                
                case 8:
                    Console.WriteLine("enter Room number: ");
                    int roomNumber;
                    while (!int.TryParse(Console.ReadLine(), out roomNumber) || roomNumber <= 0)
                    {
                        Console.WriteLine("invalid room number  enter again : ");
                    }

                    Room updateRoom = rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);

                    if (updateRoom == null)
                    {
                        Console.WriteLine("room not fount ");
                        break;
                    }

                    double oldprice = updateRoom.PricePerNight;
                    
                    Console.WriteLine("enter new price : ");
                    double newPrice;
                    while (!double.TryParse(Console.ReadLine(), out newPrice) || newPrice <= 0)
                    {
                        Console.WriteLine("invalid price enter a positive number: ");
                    }

                    updateRoom.PricePerNight = newPrice;
                    
                    Console.WriteLine();
                    Console.WriteLine("room price update successfully");
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("room roomNumber: " + updateRoom.RoomNumber);
                    Console.WriteLine("old price : " + oldprice.ToString("F2"));
                    Console.WriteLine("new price : " + updateRoom.PricePerNight.ToString("F2" + "OMR"));
                    break;
                case 9:
                    Console.WriteLine("enter  Guest name or part of name : ");
                    string searchName = Console.ReadLine();

                    var matchingGuesrs = guests.Where(g => g.GuestName.ToLower().Contains(searchName.ToLower()));

                    if (!matchingGuesrs.Any())
                    {
                        Console.WriteLine("no guests matches that name ");
                        break;
                    }
                    
                    Console.WriteLine();
                    Console.WriteLine("guests fount : " + matchingGuesrs.Count());

                    foreach (Guest guest in matchingGuesrs)
                    {
                        Console.WriteLine("---------------");
                        Console.WriteLine("guest ID : " + guest.GuestID);
                        Console.WriteLine("guest name : " + guest.GuestName);
                        Console.WriteLine("room number : " + guest.RoomNumber);
                    }
                    break;
                case 10:
                    Console.WriteLine("------Room Type Breakdown Report------");
                    string[] roomTypes = { "Single", "Double", "Suite" };

                    foreach (string type in roomTypes)
                    {
                        int count = rooms.Count(r => r.RoomType.Equals(type, StringComparison.OrdinalIgnoreCase));
                        Console.WriteLine();
                        Console.WriteLine(type + "rooms ");
                        Console.WriteLine("count : " + count);
                        if (count > 0)
                        {
                            double averagePrice = rooms
                                .Where(r => r.RoomType.Equals(type, StringComparison.OrdinalIgnoreCase))
                                .Average(r => r.PricePerNight);
                            Console.WriteLine("average price : " + averagePrice.ToString("F2") + "OMR");
                        }
                        else
                        {
                            Console.WriteLine("average price : N/A" );
                        }
                    }
                    Console.WriteLine();

                    if (rooms.Any())
                    {
                        Console.WriteLine("overall average price : " + rooms.Average(r => r.PricePerNight).ToString("F2") + "OMR");
                    }
                    else
                    {
                        Console.WriteLine("no rooms available ");
                    }

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