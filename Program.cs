using System;

namespace CinemaApp
{
    class Program

    {
        static Cinema Cnm;
        static void Main(string[] args)
        {
            Entrance();
            Menu();
            Application();
            






        }







        static void Entrance()
        {
            Console.Write("1-Film Name: ");
            string name = Console.ReadLine();
          
            Console.Write("2-Full Ticket Price: ");
            int fullTicketPrice = Convert.ToInt32(Console.ReadLine());

            Console.Write("3-Half Ticket Price: ");
            int halfTicketPrice = Convert.ToInt32(Console.ReadLine());

            Console.Write("4-Capacity: ");
            int capacity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Cnm = new Cinema(capacity,name,fullTicketPrice,halfTicketPrice);
        }

        static void Menu()
        {
            Console.WriteLine("1-Sell Ticket");
            Console.WriteLine("2-Return Ticket");
            Console.WriteLine("3-Status Report");
            Console.WriteLine("4-Exit");
            Console.WriteLine();
        }


        static string Application()
        {

        

            while (true)
            {
                
                Console.Write("Selection: ");
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        TicketSale();
                        break;


                    case "2":
                        TicketReturn();
                        break;

                    case "3":
                        StatusReport();
                        break;

                    case "4":
                        Environment.Exit(0);
                        break;
                }
            }
        }

        static void TicketSale()
        {

            Console.WriteLine("Sell Ticket");    
            Console.Write("Number of Full Ticket: ");
            int numberOfFullTicket = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number of Half Ticket: ");
            int numberOfHalfTicket = Convert.ToInt32(Console.ReadLine());

            Cnm.updateTotalTickets(numberOfFullTicket, numberOfHalfTicket);
       

            if(Cnm.Capacity >  numberOfFullTicket + numberOfHalfTicket)
            {
                Console.WriteLine("Process is Done...");
            } else
            {
                Console.WriteLine();
                Console.WriteLine("Capacity is not enough.Please change your numbers");
       
            }

            Console.WriteLine("");
        }

        static void TicketReturn()
        {
            Console.WriteLine("Return Ticket");
            Console.WriteLine("Number of Full Ticket: ");
            int rNumberOfFullTicket = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number of Half Ticket: ");
            int rNumberOfHalfTicket = Convert.ToInt32(Console.ReadLine());

            Cnm.updateTotalTickets(-rNumberOfFullTicket, -rNumberOfHalfTicket);
            Console.WriteLine(Cnm.Capacity);

        }

        static void StatusReport()
        {
            Console.WriteLine("Status Data");
            Console.WriteLine("Film: " + Cnm.FilmName);

            Console.WriteLine("Capacity: " + Cnm.Capacity);

            Console.WriteLine("Price of Full Ticket: " + Cnm.PriceOfFullTicket);
            Console.WriteLine("Price of Half Ticket: " + Cnm.PriceOfHalfTicket);

            Console.WriteLine("Number of Full Ticket: " + Cnm.TotalFullTicket);
            Console.WriteLine("Number of Half Ticket: " + Cnm.TotalHalfTicket);

            Console.WriteLine("Ciro: " + Cnm.Ciro);
            Console.WriteLine("Number of Free Seats: " + (Cnm.Capacity));
        }

    }
}

