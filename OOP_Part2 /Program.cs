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
        //menu 
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