using System;
using System.Collections.Generic;
using System.IO;
using System.Dynamic;
using System.Numerics;

namespace CardDraw
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            DeckOfCards myDeck = new DeckOfCards();
            FiveCardDraw fiveCardDraw = new FiveCardDraw();
            fiveCardDraw.PlayRound();



            //cycle through deck
            foreach(Card card in myDeck.Deck)
            {
                Console.WriteLine(card.ToString());
            }
           Console.ReadLine();


         

    }


       


       
    }

   
}
