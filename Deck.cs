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
        private string[] shuffleDeck = new string[52];

        public void menu()
        {
            string choice;
            string choice2;
            bool match = false;
            int x = 0;

            do
            {
                Console.Write("\nShuffle, Draw card, or Quit: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "shuffle":

                        for (int i = 0; i < 52; i++)
                        {
                            shuffleDeck[i] = "";
                        }

                        for (int i = 0; i < 52; i++)
                        {
                            shuffleDeck[i] = initialState[i];
                        }

                        do {
                            Console.WriteLine("\nSHUFFLE #" + (x + 1));
                            shuffleDeck = shuffle(shuffleDeck);
                            ToString(shuffleDeck);
                            match = equals(shuffleDeck, initialState);
                            x++;                         
                        } while ((match != true) || (x == 20));
                        break;
                    case "draw card":
                        do { 
                            Console.Write("\nDraw card by index or value? ");
                            choice2 = Console.ReadLine().ToLower();
                        
                            if (choice2 == "index")
                            {
                                getIndex(shuffleDeck);
                            }
                            else if (choice2 == "value")
                            {
                                getCard(shuffleDeck);
                            }
                            else
                            {
                                Console.WriteLine("\nINVALID OPTION");
                            }
                        } while ((choice2 != "index") || (choice2 == "value"));
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

        public bool equals(string[] shuffleDeck, string[] initialState)
        {
            bool match = true;

            for(int i = 0; i < 52; i++)
            {
                if(shuffleDeck[i] != initialState[i])
                {
                    match = false;
                }
            }

            if (match == true)
            {
                Console.WriteLine("\nMATCHING DECKS");
                return true;
            } 
            else
            {
                Console.WriteLine("\nNONMATCHING DECKS");
                return false;
            }
        }

        public string[] shuffle(string[] shuffleDeck)
        {
            string[] tempDeck = new string[52];
            string[] deckHalf1 = new string[26];
            string[] deckHalf2 = new string[26];

            int z = 0;

            int j = 0;
            int k = 1;

            for(int i = 0; i < 52; i++)
            {
                tempDeck[i] = "";
            }

            for (int x = 0; x < 26; x++)
            {
                deckHalf1[x] = shuffleDeck[x];
            }

            for (int y = 26; y < 52; y++)
            {
                deckHalf2[z] = shuffleDeck[y];
                z++;

            }

            for (int i = 0; i < 26; i++)
            {
                tempDeck[j] = deckHalf1[i];

                j = j + 2;

                tempDeck[k] = deckHalf2[i];

                k = k + 2;
            }

            return tempDeck;
        }

        public void ToString(string[] deck)
        {
            for(int i = 0; i < 4; i++)
            {
                for (int x = 0; x < 13; x++)
                {
                    Console.Write(deck[(i * 13) + x] + " ");
                }
                Console.WriteLine();
            }
        }

        public void getIndex(string[] shuffleDeck)
        {
            int index;

            Console.Write("\nReturn a card from which index? ");
            index = Console.Read();

            Console.WriteLine("The card in index " + index +
                " was the " + shuffleDeck[index]);
        }

        public void getCard(string[] shuffleDeck)
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