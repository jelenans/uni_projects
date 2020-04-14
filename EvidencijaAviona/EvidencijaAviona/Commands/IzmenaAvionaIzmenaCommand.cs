using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EvidencijaAviona.ViewModel;
using System.Windows;

namespace EvidencijaAviona.Commands
{
  
    public class IzmenaAvionaIzmenaCommand : IzmenaAvionaAbstractCommand
    {

        public IzmenaAvionaIzmenaCommand(IIzmenaAvionaViewModel vm)
            : base(vm)
        {

        }
        public override bool CanExecute(object parameter)
        {
           
            return true;
        }

        public override void Execute(object parameter)
        {
            _vm.MainWindowModel.Repository.SacuvajAvion(_vm.TrenutniAvion); 
            //   Console.WriteLine(_vm.TrenutniAvion.Oznaka);
            //   MessageBox.Show("OZNAKA: " + _vm.TrenutniAvion.Oznaka.ToString());
            _vm.CloseTrigger(); 
        }
    }
}
