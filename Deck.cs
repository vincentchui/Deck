using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck
{
    class Deck
    {
        private string[] initialState = {"AH", "2H", "3H", "4H",
        "5H", "6H", "7H", "8H", "9H", "10H", "JH", "QH", "KH",
        "AC", "2C", "3C", "4C", "5C", "6C", "7C", "8C", "9C",
        "10C", "JC", "QC", "KC", "AD", "2D", "3D", "4D", "5D",
        "6D", "7D", "8D", "9D", "10D", "JD", "QD", "KD", "AS",
        "2S", "3S", "4S", "5S", "6S", "7S", "8S", "9S", "10S",
        "JS", "QS", "KS"};
        private string[] deckH1 = new string[26];
        private string[] deckH2 = new string[26];
        private string[] shuffleDeck = new string[52];

        public void menu()
        {
            string choice;

            do
            {
                Console.Write("\nShuffle, Compare or Quit: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "shuffle":
                        for (int i = 0; i < 25; i++)
                        {
                            deckH1[i] = "";
                            deckH2[i] = "";
                        }

                        for (int i = 0; i < 52; i++)
                        {
                            shuffleDeck[i] = "";
                        }
                        halveDeck();
                        break;
                    case "compare":
                        if ((deckH1 != null) || (deckH2 != null))
                        {
                            equals(deckH1, deckH2);
                        }
                        else
                        {
                            Console.WriteLine("\nRUN SHUFFLE BEFORE COMPARE");
                        }
                        break;
                    case "quit":
                        Console.WriteLine("\nGoodbye");
                        break;
                    default:
                        Console.WriteLine("\nINVALID OPTION");
                        break;
                }
            } while (choice != "quit");
        }

        public void equals(string[] a, string[] b)
        {
            bool match = true;

            for(int i = 0; i < 52; i++)
            {
                if(a[i] != b[i])
                {
                    match = false;
                    break;
                }
            }

            if (match == true)
            {
                Console.WriteLine("\nMATCHING DECKS");
            } 
            else
            {
                Console.WriteLine("\nNONMATCHING DECKS");
            }
        }

        public void halveDeck()
        {
            int x = 0;

            for(int i = 0; i < 25; i++)
            {
                deckH1[i] = initialState[i];
            }

            for(int i = 26; i < 51; i++)
            {
                deckH2[x] = initialState[i];
                x++;
            }
        }

        public void shuffle()
        {
            bool match = false;

            for(int i = 0; i < 25; i++)
            {
                
                for(int x = 0; x < 51; x++)
                {
                    if(shuffleDeck[x] == initialState[x])
                    {
                        match = true;
                        if(match == true)
                        {
                            Console.WriteLine("\nShuffled deck matches initial deck");
                            menu();
                        }
                    }
                    
                }
            }
        }

        public void toString(string[] deck)
        {
            Console.WriteLine(deck);
        }

        public void getIndex(string[] shuffleD)
        {
            int index;

            Console.Write("\nReturn a card from which index? ");
            index = Console.Read();

            Console.WriteLine("The card in index " + index +
                " was the " + shuffleD[index]);
        }

        public void getCard()
        {
            string search;
            int index;

            Console.Write("\nWhat card to search for? ");
            search = Console.ReadLine().ToUpper();

            for(int i = 0; i < shuffleDeck.Length; i++)
            {
                if(search == shuffleDeck[i])
                {
                    index = i;
                    Console.WriteLine(search + "was found in index " + index);

                }
            }
        }
    }
}
