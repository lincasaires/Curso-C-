using Excecoes_Personalizadas.Entities;
using System;
using Excecoes_Personalizadas.Entities.Exceptions;

namespace Excecoes_Personalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int roomNumber = int.Parse(Console.ReadLine());
                Console.Write("Check-in date: (dd/MM/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date: (dd/MM/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());
                Reservation reservation = new Reservation(roomNumber, checkin, checkout);
                Console.WriteLine(reservation);
                Console.WriteLine();

                Console.WriteLine("Enter data to update reservation:");
                Console.Write("Check-in date: (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date: (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());
                reservation.UpdateDates(checkin, checkout);
                Console.WriteLine(reservation);
            }

            catch(DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }

        }
    }
}
