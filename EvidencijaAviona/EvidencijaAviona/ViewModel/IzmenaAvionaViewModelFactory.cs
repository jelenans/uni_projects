using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvidencijaAviona.ViewModel
{
   public class IzmenaAvionaViewModelFactory : EvidencijaAviona.ViewModel.IIzmenaAvionaViewModelFactory
    {
        private static IzmenaAvionaViewModelFactory _f = null;

        public static IzmenaAvionaViewModelFactory getInstance()
        {
            if (_f == null) _f = new IzmenaAvionaViewModelFactory();
            return _f;
        }

        private IzmenaAvionaViewModelFactory()
        {

        }

        public IIzmenaAvionaViewModel getModel(IMainWindowViewModel model, Model.IAvion av)
        {
            IIzmenaAvionaViewModel vm = new IzmenaAvionaViewModel(model, av);
            return vm;
        }
    }
}
