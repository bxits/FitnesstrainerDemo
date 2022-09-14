using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommandHelper;

namespace Fitnesstrainer.ViewModel
{
    class MainViewModel
    {
        private string _nameTrainingseinheit; //Feld
        private ICommand _speichernCommand;
        

        public string NameTrainingseinheit
        {
            get { return _nameTrainingseinheit; }
            set { _nameTrainingseinheit = value; }
        }

        public ICommand SpeichernCommand
        {
            get
            {
                if (_speichernCommand == null)
                    _speichernCommand = new RelayCommand(c => SpeichereTrainingseinheit());
                return _speichernCommand;
            }
        }

        
        public MainViewModel()
        {

        }

        private void SpeichereTrainingseinheit()
        {
            
        }
    }
}
