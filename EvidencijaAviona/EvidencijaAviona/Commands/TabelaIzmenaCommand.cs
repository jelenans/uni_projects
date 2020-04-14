using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EvidencijaAviona.ViewModel;
using EvidencijaAviona.Model;

namespace EvidencijaAviona.Commands
{
  
    public class TabelaIzmenaCommand : TabelaAbstractCommand
    {
        public TabelaIzmenaCommand(IMainWindowViewModel vm)
            : base(vm)
        {

        }
        public override bool CanExecute(object parameter)
        {
            return (_vm.Selected != null);
        }

        public override void Execute(object parameter)
        {
            IIzmenaAvionaViewModel ivm = (IIzmenaAvionaViewModel)parameter;
           ivm.TrenutniAvion= _vm.Repository.VratiAvionId(_vm.Selected.Oznaka);
            _vm.izmenaAviona(ivm);
        }
    }
}
