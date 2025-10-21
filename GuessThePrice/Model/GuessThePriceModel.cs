using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CommunityToolkit.Mvvm.Input;

namespace GuessThePrice.Model
{
    public class GuessThePriceModel
    {
        private int _min;
        private int _max;
        private string _actPrice;
        Random _random;
        private int _OpGuess;
        private string asd;
        public GuessThePriceModel()
        {
            _random = new Random();

        }

        public void NextRound()
        {
            _min = _random.Next(1, 200);
            _max = _random.Next(900, 1200);
            _actPrice = Convert.ToString(_random.Next(_min, _max));
            _OpGuess = _random.Next(_min, _max);
            SetUpNextRound.Invoke(this, new GuessThePriceEventArgs(_min, _max, "??????", _OpGuess, asd));

            
        }
        

        public event EventHandler<GuessThePriceEventArgs>? SetUpNextRound;
        public event EventHandler<GuessThePriceEventArgs>? AfterGuess;

        public RelayCommand RelayCommand { get; set; }
        public void AfterPlayerGuess(int num)
        {
            if(num < Convert.ToUInt32(_actPrice) && _OpGuess < Convert.ToUInt32(_actPrice) && num < _OpGuess )
            {
                SetUpNextRound.Invoke(this, new GuessThePriceEventArgs(_min, _max, _actPrice, _OpGuess, ""));
                MessageBox.Show("Opponent Won this round");
            }
            else if (num < Convert.ToUInt32(_actPrice) && _OpGuess < Convert.ToUInt32(_actPrice) && num > _OpGuess)
            {
                SetUpNextRound.Invoke(this, new GuessThePriceEventArgs(_min, _max, _actPrice, _OpGuess, ""));
                MessageBox.Show("Player Won this round");

            }
            else if(num < Convert.ToUInt32(_actPrice) && _OpGuess > Convert.ToUInt32(_actPrice))
            {
                SetUpNextRound.Invoke(this, new GuessThePriceEventArgs(_min, _max, _actPrice, _OpGuess, ""));
                MessageBox.Show("Player Won this round");
            }
            else if (num > Convert.ToUInt32(_actPrice) && _OpGuess < Convert.ToUInt32(_actPrice))
            {
                SetUpNextRound.Invoke(this, new GuessThePriceEventArgs(_min, _max, _actPrice, _OpGuess, ""));
                MessageBox.Show("Opponent Won this round");
            }
            else if (num > Convert.ToUInt32(_actPrice) && _OpGuess > Convert.ToUInt32(_actPrice))
            {
                SetUpNextRound.Invoke(this, new GuessThePriceEventArgs(_min, _max, _actPrice, _OpGuess, ""));
                MessageBox.Show("Both players went over");
            }
        }

    }
}
