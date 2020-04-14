using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EvidencijaAviona.ViewModel;

namespace EvidencijaAviona.Commands
{
   
    public class TabelaBrisanjeCommand : TabelaAbstractCommand
    {
        public TabelaBrisanjeCommand(IMainWindowViewModel vm) : base(vm)
        {

        }

        public override bool CanExecute(object parameter)
        {
            return (_vm.Selected != null); 
        }

        public override void Execute(object parameter)
        {
            _vm.Repository.ObrisiAvion(_vm.Selected);
        }
    }
}
