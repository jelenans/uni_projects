using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EvidencijaAviona.ViewModel;
using System.Windows.Input;

namespace EvidencijaAviona.Commands
{
    public abstract class IzmenaAvionaAbstractCommand : ICommand
    {
        protected readonly IIzmenaAvionaViewModel _vm;

        public IzmenaAvionaAbstractCommand(IIzmenaAvionaViewModel vm)
        {
            _vm = vm;
        }

        #region ICommand Members

        public abstract bool CanExecute(object parameter);


        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public abstract void Execute(object parameter);

        #endregion
    }
}
