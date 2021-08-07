using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfPerson
{
    class RelayCommand : ICommand
    {
        #region Fields
        private Action _execute;
        private Func<bool> _canExecute;
        #endregion

        #region Constructors
        public RelayCommand(Action execute) : this(execute, null) { }

        public RelayCommand(Action execute, Func<bool> canExecute) 
        {
            if (execute == null)
            {
                throw new ArgumentException("execute");
            }

            _execute = execute;
            _canExecute = canExecute;
        }
        #endregion //Constructors

        #region ICommand Memeber
        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute();
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(Object parameter)
        {
            _execute();
        }
        #endregion // ICommand Members 
    }
}
