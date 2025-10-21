using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThePrice.Model
{
    public class GuessThePriceEventArgs
    {
        public int _min;
        public int _max;
        public string _act;
        public int _OPGuess;
        public string _asd;


        public GuessThePriceEventArgs(int min, int max, string act, int OpGuess, string asd) 
        {
            _min = min;
            _max = max;
            _act = act;
            _OPGuess = OpGuess;
            _asd = asd;
        }

       


    }
}
