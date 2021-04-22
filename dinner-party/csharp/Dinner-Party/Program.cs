using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace Dinner_Party
{

    public class Guest
    {
        public string Name { get; set; }
        public string Occupation { get; set; }
        public string Bio { get; set; }
    }
    
    public class Table
    {
        public List<Guest> OfGuests { get; set; } = new List<Guest>();
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            

        List<Guest> guestList = new List<Guest>()
            {
                new Guest(){
                Name = "Marilyn Monroe",
                Occupation = "entertainer",
                Bio = "(1926 - 1962) American actress, singer, model"
                },
                new Guest(){
                Name = "Abraham Lincoln",
                Occupation = "politician",
                Bio = "(1809 - 1865) US President during American civil war"
                },
                new Guest(){
                Name = "Martin Luther King",
                Occupation = "activist",
                Bio = "(1929 - 1968)  American civil rights campaigner"
                },
                new Guest(){
                Name = "Rosa Parks",
                Occupation = "activist",
                Bio = "(1913 - 2005)  American civil rights activist"
                },
                new Guest(){
                Name = "Peter Sellers",
                Occupation = "entertainer",
                Bio = "(1925 - 1980) British actor and comedian"
                },
                new Guest(){
                Name = "Alan Turing",
                Occupation = "computer scientist",
                Bio = "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
                },
                new Guest(){
                Name = "Admiral Grace Hopper",
                Occupation = "computer scientist",
                Bio = "(1906–1992) - developed early compilers, FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
                },
                new Guest(){
                Name = "Indira Gandhi",
                Occupation = "politician",
                Bio = "(1917 - 1984) Prime Minister of India 1966 - 1977"
                }
            };

            
        Table GabesTable = new Table();
        Table MattsTable = new Table();

        foreach (var guest in guestList)
            {
                //for each guest in the guest list we are looking for their occupations
                //putting those guests into the first table
                //if the first table of guests already has a guest with that occupation
                //add to the second table, which is MattsTable
                List<string> firstTable = GabesTable.OfGuests.Select(g => g.Occupation).ToList();
                if (firstTable.Contains(guest.Occupation))
                {
                    MattsTable.OfGuests.Add(guest);
                }
                else
                {
                    GabesTable.OfGuests.Add(guest);
                }

            };

        Console.WriteLine("GabesTable");
        foreach (var guest in GabesTable.OfGuests)
        {
            Console.WriteLine($"{guest.Name} {guest.Occupation} {guest.Bio}");
        }

        Console.WriteLine("MattsTable"); 
        foreach (var guest in MattsTable.OfGuests)
        {
            Console.WriteLine($"{guest.Name} {guest.Occupation} {guest.Bio}");
        }

            // foreach (var (guest, firstTable) in from guest in guestList
            //                                     let firstTable = GabesTable.OfGuests.Select(g => g.Occupation).ToList()
            //                                     select (guest, firstTable))
            // {
            //     if (firstTable.Contains(guest.Occupation))
            //     {
            //         MattsTable.OfGuests.Add(guest);
            //     }
            //     else
            //     {
            //         GabesTable.OfGuests.Add(guest);
            //     }
            // }
        }
    }
}
