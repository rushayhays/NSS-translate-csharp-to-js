using System;
using System.Collections.Generic;
using System.Linq;

namespace DinnerParty
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here we make two instances of Table and add them to a List<Table>
            Table table1 = new Table("Table 1");
            Table table2 = new Table("Table 2");
            List<Table> allTables = new List<Table>{table1, table2};

            //Here we create a guestList
            List<Guest> guests = GetGuests();

            //Now we create a function to assign guests to tables. No two people of the same occupation
            //should be at a table together
            foreach (Guest item in guests)
            {
                List<string> allOccupationsAtTable1 = allTables[0].GetAllOccupations();
                if(allOccupationsAtTable1.Contains(item.Occupation)){
                    allTables[1].AddGuest(item);
                }else{
                    allTables[0].AddGuest(item);
                }
            }

            //Now we print out the tables with thier guests
            foreach(Table singleTable in allTables){
                Console.WriteLine(singleTable.Name);
                singleTable.PrintGuests();
                Console.WriteLine("");
            }


            List<Guest> GetGuests(){
                Guest guest1 = new Guest()
                {
                    Name = "Marilyn Monroe",
                    Occupation = "entertainer",
                    Bio = "(1926 - 1962) American actress, singer, model"
                };
                 Guest guest2 = new Guest()
                {
                    Name = "Abraham Lincoln",
                    Occupation = "politician",
                    Bio = "(1809 - 1865) US President during American civil war"
                };
                 Guest guest3 = new Guest()
                {
                    Name = "Martin Luther King",
                    Occupation = "activist",
                    Bio = "(1929 - 1968)  American civil rights campaigner"
                };
                 Guest guest4 = new Guest()
                {
                    Name = "Rosa Parks",
                    Occupation = "activist",
                    Bio = "(1913 - 2005)  American civil rights activist"
                };
                 Guest guest5 = new Guest()
                {
                    Name = "Peter Sellers",
                    Occupation = "entertainer",
                    Bio = "(1925 - 1980) British actor and comedian"
                };
                 Guest guest6 = new Guest()
                {
                    Name = "Alan Turing",
                    Occupation = "computer scientist",
                    Bio = "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
                };
                 Guest guest7 = new Guest()
                {
                    Name = "Admiral Grace Hopper",
                    Occupation = "computer scientist",
                    Bio = "(1906 - 1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
                };
                 Guest guest8 = new Guest()
                {
                    Name = "Indira Gandhi",
                    Occupation = "politician",
                    Bio = "(1917 - 1984) Prime Minister of India 1966 - 1977"
                };
                List<Guest> bigGuestList = new List<Guest>{guest1,guest2,guest3,guest4,guest5,guest6,guest7,guest8};
                return bigGuestList;
            }

        
        }
    }
}
