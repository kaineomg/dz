using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Card
    {
       
        public enum val
        {
            one = 1,
            two,
            three,
            four,
            five,
            six,
            seven,
            eight,
            nine,
            ten,
            valet,
            queen,
            king,
            ace
        }
        public enum suit
        {
            spades,
            clubs,
            hearts,
            diamonds
        }
        public suit Suit { get; private set; }
        public val Value { get; private set; }
    Card (int val, int mas)
        {
            Suit = mas;
            Value = val; 
           
        }




    }
}
