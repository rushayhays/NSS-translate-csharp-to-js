using System;
using System.Collections.Generic;

namespace Insulter
{
    class Program
    {
        static void Main(string[] args)
        {
            //First we make a list of insults
            List<string> insults = new List<string>{
                "You look like what morning breath smells like.",
                "If you tried to give me cpr I would probably throw myself back under water",
                "I am not a fan of you",
                "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
                "I'd rather walk than be on the same plane as you",
                "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
                "Do you have to be so...like that?"
            };

            //Now we need to be able to generate a random number that's within the range of the insult list
            int GetRandomInt(int min, int max){
                Random r = new Random();
                int randomNumber = r.Next(min, max);
                return randomNumber;
            }

            //We need a new empty list
            List<int> indexes = new List<int>();
            //Now we need to fill it with 3 randomly chosen insults. No repeats
            while(indexes.Count < 3){
                int candidate = GetRandomInt(0, insults.Count-1);
                if(!indexes.Contains(candidate)){
                    indexes.Add(candidate);
                }
            }

            //Now we print the three randomly chosen insults
            for(int x =0; x < indexes.Count; x++){
                int insultToPrint = indexes[x];
                Console.WriteLine(insults[insultToPrint]);
            }

        }
    }
}
