using System;
using System.Collections.Generic;
using System.Text;

namespace CardDraw
{
    class Card
    {
       
            string rank;
            string suit;
            int val;

            public int Value
            {
                get
                {
                    return val;
                }

                set
                {
                    val = value;
                }
            }

            public Card(string rank, string suit, int val)
            {
                this.rank = rank;
                this.suit = suit;
                this.val = val;
            }

        public override string ToString()
        {
            return string.Format("{0,2} {1}", rank, suit);
        }



    }


    class DeckOfCards
    {
        //gets or sets a List of Card objects

        public List<Card> Deck { get; set; }
        private const int NUMBER_OF_CARDS = 52;


        public DeckOfCards()
        {
            //all faces and suits in two arrays with corresponding value
            string[] faces = { "A", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            string[] suits = { "♠", "♥", "♦", "♣" };
            int[] value = { 14, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            //new deck
            Deck = new List<Card>();

            //populate entire deck array with Card objects
            for (int count = 0; count < NUMBER_OF_CARDS; count++)
            {
                Deck.Add(new Card(faces[count % 13], suits[count / 13], value[count % 13]));
            }

        }

        public void Shuffle()
        {
            Random randNum = new Random();
            int nRand;
            Card temp;

            //swap every card in the deck with another card
            for (int n = 0; n < Deck.Count; n++)
            {
                nRand = randNum.Next(1, Deck.Count);
                temp = Deck[n];
                Deck[n] = Deck[nRand];
                Deck[nRand] = temp;
            }

        }

        public Card Deal()
        {
            //deal top card and remove from deck.
            Card temp = Deck[0];
            Deck.RemoveAt(0);
            return temp;
        }

    }


    class FiveCardDraw
    {

        //gets or sets the cards in the Player's hand.

        public List<Card> PlayerHand { get; set; }

        //gets or sets the cards in the Deck.
        public DeckOfCards deckOfCards { get; set; }

        //creates a new game of Five Card Draw with a deck of 52 cards.

        public FiveCardDraw()
        {
            deckOfCards = new DeckOfCards();
            deckOfCards.Shuffle();
            PlayerHand = new List<Card>();
        }




        private bool[] Discard;
        


        // plays a hand of 5 card draw.
        public void PlayRound()
        {

            Discard = new bool[5] { false, false, false, false, false };
            string userChoice;
            int discardMe = 0;
            
            
            //deal five cards to player
            for (int n = 0; n < 5; n++)
            {
                PlayerHand.Add(deckOfCards.Deal());
            }

            do
            {
                ShowPlayerHand();

                Console.WriteLine("Type the number of the card in your hand and hit the Enter to toggle between Keep/Discard. Type 'D' to finalize discard.");
                userChoice = Console.ReadLine();

                //input validation loop
                while (userChoice != "D" && !int.TryParse(userChoice, out discardMe))
                {
                    Console.WriteLine("Invalid choice. Try Again: ");
                    userChoice = Console.ReadLine();
                }

                //togggle element using ternary operator.
                if (userChoice != "D" && discardMe > 0 && discardMe < 6)
                {
                    Discard[discardMe - 1] = Discard[discardMe - 1] == true ? false : true;
                }

            } while (userChoice != "D");

            FinalizeDiscard();
            ShowPlayerHand();

        }// end PlayRound

        private void FinalizeDiscard()
        {
            for(int n = 0; n < PlayerHand.Count;n++)
            {
                //if card marked to be discarded, replace with a card from deck
                if(Discard[n])
                {
                    deckOfCards.Deck.Add(PlayerHand[n]);
                    PlayerHand[n] = deckOfCards.Deal();
                }

            }


            //reset Discard bool array.
            Discard = new bool[5] { false, false, false, false, false };

        }







        //Displays each card in the PLayers hand.

        public void ShowPlayerHand()
        {
            for (int n = 0; n < PlayerHand.Count; n++)
            {
                Console.WriteLine("Card # " + (n + 1) + ": " + PlayerHand[n]);
            }
        }

    }




}
