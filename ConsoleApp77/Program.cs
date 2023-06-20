using System;
using System.Collections.Generic;

class FlightBookingApp
{
    static void Main()
    {
        Console.WriteLine("Welcome to Flight Booking App!");

        List<Flight> availableFlights = new List<Flight>()
        {
            new Flight("Flight 1", "New York", "London", new DateTime(2023, 7, 1, 8, 0, 0)),
            new Flight("Flight 2", "Paris", "Tokyo", new DateTime(2023, 7, 2, 10, 30, 0)),
            new Flight("Flight 3", "Dubai", "Sydney", new DateTime(2023, 7, 3, 15, 45, 0)),
            new Flight("Flight 4", "Los Angeles", "Beijing", new DateTime(2023, 7, 4, 12, 15, 0))
        };

        List<Flight> bookedFlights = new List<Flight>();

        bool continueBooking = true;

        while (continueBooking)
        {
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("1. View available flights");
            Console.WriteLine("2. Book a flight");
            Console.WriteLine("3. Cancel a booked flight");
            Console.WriteLine("4. View booked flights");
            Console.WriteLine("5. Advanced search");
            Console.WriteLine("6. Sort flights");
            Console.WriteLine("7. Multiple booking");
            Console.WriteLine("8. View flight details");
            Console.WriteLine("9. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Available Flights:");
                    if (availableFlights.Count > 0)
                    {
                        for (int i = 0; i < availableFlights.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {availableFlights[i]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No available flights found.");
                    }
                    break;
                case "2":
                    Console.Write("Enter the flight number to book: ");
                    int flightIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (flightIndex >= 0 && flightIndex < availableFlights.Count)
                    {
                        Flight bookedFlight = availableFlights[flightIndex];
                        bookedFlights.Add(bookedFlight);
                        availableFlights.RemoveAt(flightIndex);
                        Console.WriteLine($"Flight '{bookedFlight}' booked successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid flight number.");
                    }
                    break;
                case "3":
                    Console.Write("Enter the flight number to cancel: ");
                    int bookedFlightIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (bookedFlightIndex >= 0 && bookedFlightIndex < bookedFlights.Count)
                    {
                        Flight cancelledFlight = bookedFlights[bookedFlightIndex];
                        availableFlights.Add(cancelledFlight);
                        bookedFlights.RemoveAt(bookedFlightIndex);
                        Console.WriteLine($"Flight '{cancelledFlight}' cancelled successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid flight number.");
                    }
                    break;
                case "4":
                    Console.WriteLine("Booked Flights:");
                    if (bookedFlights.Count > 0)
                    {
                        for (int i = 0; i < bookedFlights.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {bookedFlights[i]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No booked flights found.");
                    }
                    break;
                case "5":
                    // Implement advanced search functionality
                    Console.WriteLine("Advanced Search: (Under development)");
                    break;
                case "6":
                    // Implement sorting functionality
                    Console.WriteLine("Sorting: (Under development)");
                    break;
                case "7":
                    // Implement multiple booking functionality
                    Console.WriteLine("Multiple Booking: (Under development)");
                    break;
                case "8":
                    Console.Write("Enter the flight number to view details: ");
                    int flightDetailsIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (flightDetailsIndex >= 0 && flightDetailsIndex < availableFlights.Count)
                    {
                        Flight selectedFlight = availableFlights[flightDetailsIndex];
                        Console.WriteLine("Flight Details:");
                        Console.WriteLine(selectedFlight.GetFlightDetails());
                    }
                    else
                    {
                        Console.WriteLine("Invalid flight number.");
                    }
                    break;
                case "9":
                    continueBooking = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        Console.WriteLine("\nThank you for using the Flight Booking App!");
    }
}

class Flight
{
    public string Number { get; set; }
    public string Departure { get; set; }
    public string Destination { get; set; }
    public DateTime DepartureTime { get; set; }

    public Flight(string number, string departure, string destination, DateTime departureTime)
    {
        Number = number;
        Departure = departure;
        Destination = destination;
        DepartureTime = departureTime;
    }

    public override string ToString()
    {
        return $"{Number} - {Departure} to {Destination} ({DepartureTime})";
    }

    public string GetFlightDetails()
    {
        // Implement flight details information
        return "Flight details: (Under development)";
    }
}
