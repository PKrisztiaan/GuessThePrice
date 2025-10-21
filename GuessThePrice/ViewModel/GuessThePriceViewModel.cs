using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using GuessThePrice.Model;

namespace GuessThePrice.ViewModel
{
    public class GuessThePriceViewModel : ViewModelBase
    {
        private GuessThePriceModel _model;
        private int _min;
        private int _max;
        private int _OpGuess;
        private int _PlayerGuess;
        private string _winnerText;

        private string _actPrice;

        public int Min
        {
            get { return _min; }
            set
            {
                if (_min != value)
                {
                    _min = value;
                    OnPropertyChanged();
                }
            }
        }
        public int Max 
        {
            get { return _max; }

            set
            {
                if (_max != value)
                {
                    _max = value;
                    OnPropertyChanged();
                }
            } 
        
        }
        
        public string Act 
        {
            get { return _actPrice; }
            set
            {
                if (_actPrice != value)
                {
                    _actPrice = value;
                    OnPropertyChanged();
                }
            } 
        }

        public int OpGuess
        {
            get { return _OpGuess; }

            set
            {
                if (_OpGuess != value)
                {
                    _OpGuess = value;
                    OnPropertyChanged();
                }
            }

        }
        public int PlayerGuess
        {
            get { return _min; }
            set
            {
                if (_PlayerGuess != value)
                {
                    _PlayerGuess = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Winner
        {
            get { return _winnerText; }
            set
            {
                if (_winnerText != value)
                {
                    _winnerText = v
                        alue;
                    OnPropertyChanged();
                }
            }
        }

        public RelayCommand NextRoundCommand { get; private set; }
        public GuessThePriceViewModel(GuessThePriceModel model) 
        {
            _model = model;
            NextRoundCommand = new RelayCommand(_model.NextRound);
            _model.SetUpNextRound += _model_SetUpNextRound;                        
            _model.NextRound();
            
        }

        private void _model_SetUpNextRound(object? sender, GuessThePriceEventArgs e)
        {
            Min = e._min;
            Max = e._max;
            Act = e._act;
        }
    }
}
