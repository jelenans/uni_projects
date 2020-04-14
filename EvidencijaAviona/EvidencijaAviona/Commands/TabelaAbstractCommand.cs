using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using EvidencijaAviona.ViewModel;

namespace EvidencijaAviona.Commands
{
  
    public abstract class TabelaAbstractCommand : ICommand
    {
        protected readonly IMainWindowViewModel _vm;

        public TabelaAbstractCommand(IMainWindowViewModel vm)
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
