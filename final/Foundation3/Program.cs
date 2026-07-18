using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address(
            "123 College Ave",
            "Rexburg",
            "Idaho",
            "USA");

        Address receptionAddress = new Address(
            "456 Grand Hotel",
            "Salt Lake City",
            "Utah",
            "USA");

        Address outdoorAddress = new Address(
            "789 Central Park",
            "New York",
            "New York",
            "USA");

        Lecture lecture = new Lecture(
            "Leadership Seminar",
            "Learn leadership skills from industry experts.",
            "October 15, 2026",
            "6:00 PM",
            lectureAddress,
            "John Maxwell",
            250);

        Reception reception = new Reception(
            "Company Networking Night",
            "Meet professionals and expand your network.",
            "November 10, 2026",
            "7:00 PM",
            receptionAddress,
            "rsvp@company.com");

        OutdoorGathering outdoor = new OutdoorGathering(
            "Community Picnic",
            "Enjoyed food, games, and live music.",
            "July 20, 2026",
            "12:00 PM",
            outdoorAddress,
            "Sunny with a high of 82°F");

        Console.WriteLine("===== LECTURE =====");
        Console.WriteLine(lecture.StandardDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.FullDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.ShortDescription());

        Console.WriteLine("\n===========================\n");

        Console.WriteLine("===== RECEPTION =====");
        Console.WriteLine(reception.StandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.FullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.ShortDescription());

        Console.WriteLine("\n===========================\n");

        Console.WriteLine("===== OUTDOOR GATHERING =====");
        Console.WriteLine(outdoor.StandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoor.FullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoor.ShortDescription());
    }
}