using System;

namespace Exercicio_Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int roomQnt = 10;
            Rents[] vetRoom = new Rents[roomQnt];
            string name;
            string email;
            int room;

            Console.Write("How many rooms will be rented? "); int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Rent #" + (i+1));
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Email: ");
                email = Console.ReadLine();
                Console.Write("Room: ");
                room = int.Parse(Console.ReadLine());
                vetRoom[room -1] = new Rents { Name = name, Email = email, Room = room }; 
                
            }
            

            Console.WriteLine();
            Console.WriteLine("Busy rooms:");

            for (int i = 0; i < roomQnt; i++)
            {
                if (vetRoom[i].Name != null)  
                {    
                    Console.WriteLine((i+1) + ": " + vetRoom[i].Name + ", " + vetRoom[i].Email );
                }
            }
        }
    }
}
