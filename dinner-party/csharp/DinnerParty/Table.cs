using System;
using System.Collections.Generic;

namespace DinnerParty
{
    public class Table
    {
        public string Name {get;set;}
        public List<Guest> GuestsAtTable {get;set;}
        public Table(string tableName)
        {
            Name= tableName;
            GuestsAtTable = new List<Guest>();
        }

        //This will allow us to easily add Guests
        public void AddGuest(Guest newGuest){
            GuestsAtTable.Add(newGuest);
        }
        
        //This will give us a list of all the occupations at the table
        public List<string> GetAllOccupations()
        {
            List<string> occList = new List<string>();
            for(int x = 0; x< GuestsAtTable.Count; x++){
                occList.Add(GuestsAtTable[x].Occupation);
            }
            return occList;
        }
        public void PrintGuests()
        {
            foreach(Guest item in GuestsAtTable){
                Console.WriteLine($"{item.Name} ({item.Occupation}) {item.Bio}");
            }
        }

    }

    public class Guest
    {
        public string Name {get;set;}
        public string Occupation {get;set;}
        public string Bio {get;set;}
    }
}