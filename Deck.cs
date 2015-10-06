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

        private string[] shuffleD;

        public void setDeck(string[] initialState)
        {

        }

        public void shuffle(string[] deck)
        {

        }

        public void toString(string[] deck)
        {
            Console.WriteLine(deck);
        }

        public void equals(string[] aDeck, string[] bDeck)
        {
            int match = 0;
            int mismatch = 0;

            for(int i = 0; i < aDeck.Length; i++)
            {
                if(aDeck[i] == bDeck[i])
                {
                    match++;
                } else
                {
                    mismatch++;
                }
            }
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

            for(int i = 0; i < shuffleD.Length; i++)
            {
                if(search == shuffleD[i])
                {
                    index = i;
                    Console.WriteLine(search + "was found in index " + index);

                }
            }
        }
    }
}
