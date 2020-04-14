using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EvidencijaAviona.ViewModel;
using System.Windows.Input;

namespace EvidencijaAviona.Commands
{
    public abstract class DodavanjeNovogAvionaAbstractCommand : ICommand
    {
        protected readonly IDodavanjeNovogAvionaViewModel _vm;

        public DodavanjeNovogAvionaAbstractCommand(IDodavanjeNovogAvionaViewModel vm)
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
