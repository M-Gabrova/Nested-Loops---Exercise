using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;

            while (movieName != "Finish")
            {
                int capacity = int.Parse(Console.ReadLine());

                string ticketType = Console.ReadLine();
                int seatsTaken = 0;

                while (movieName != "End")
                {
                    ticketType = Console.ReadLine();

                    if (ticketType == "student")
                    {
                        studentTickets++;
                    }
                    else if (ticketType == "standard")
                    {
                        standardTickets++;
                    }
                    else
                    {
                        kidTickets++;
                    }

                    seatsTaken++;

                    if (seatsTaken == capacity)
                    {
                        break;
                    }

                    ticketType = Console.ReadLine();


                }
                double percentFull = (double)seatsTaken / capacity * 100;
                Console.WriteLine($"{movieName} - {percentFull:F2}% full.");

                movieName = Console.ReadLine();
            }


            int totalTickets = studentTickets + standardTickets + kidTickets;
            Console.WriteLine($"Total tickets: {totalTickets}");

            double studentPercent = (double)studentTickets / totalTickets * 100;
            double standardPercent = (double)standardTickets / totalTickets * 100;
            double kidPercent = (double)kidTickets / totalTickets * 100;
            Console.WriteLine($"{studentPercent:F2}% student tickets.");
            Console.WriteLine($"{standardPercent:F2}% standard tickets.");
            Console.WriteLine($"{kidPercent:F2}% kids tickets.");
        }
    }

}
