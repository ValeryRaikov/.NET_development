using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace MinimalMVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        private object _currentViewModel;
        private readonly Presenter _upperViewModel = new Presenter();
        private readonly PresenterLowercase _lowerViewModel = new PresenterLowercase();

        public MainViewModel()
        {
            _currentViewModel = _upperViewModel;
        }

        public object CurrentViewModel
        {
            get { return _currentViewModel; }
            set
            {
                _currentViewModel = value;
                RaisePropertyChangedEvent("CurrentViewModel");
            }
        }

        public ICommand SwitchViewModelCommand
        {
            get { return new DelegateCommand(SwitchViewModel); }
        }

        private void SwitchViewModel()
        {
            CurrentViewModel = CurrentViewModel == _upperViewModel ? _lowerViewModel : (object)_upperViewModel;
        }
    }
}
