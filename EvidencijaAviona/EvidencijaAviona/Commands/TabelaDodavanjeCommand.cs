using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EvidencijaAviona.ViewModel;
using EvidencijaAviona.Model;

namespace EvidencijaAviona.Commands
{
   
    public class TabelaDodavanjeCommand : TabelaAbstractCommand
    {
        public TabelaDodavanjeCommand(IMainWindowViewModel vm) : base(vm)
        {

        }
        public override bool CanExecute(object parameter)
        {
            return true; 
        }

        public override void Execute(object parameter)
        {
            IDodavanjeNovogAvionaViewModel dnvm = (IDodavanjeNovogAvionaViewModel)parameter; 
            dnvm.TrenutniAvion = _vm.ActiveAvionFactory.newEmptyAvion(); 
            _vm.dodavanjeNovogAviona(dnvm); 
        }
    }
}
