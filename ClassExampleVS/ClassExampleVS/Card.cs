using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExampleVS
{
    class Card
    {
        //card data
        string rank;
        string suit;
        int val;

        public Card(string rank, string suit, int value)
        {
            this.Rank = rank;
            this.Suit = suit;
            this.Val = value;
        }

        //getters and setters can be created by highlighting the variables and clicking on the lightbulb to generate them (Encapsulate Fields) 
        public string Rank { get => rank; set => rank = value; }
        public string Suit { get => suit; set => suit = value; }
        public int Val { get => val; set => val = value; }


        public override string ToString()
        {
            return rank + " " + suit;
        }
    }
}
