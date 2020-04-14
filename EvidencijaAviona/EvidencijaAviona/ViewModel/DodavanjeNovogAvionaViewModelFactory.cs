using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvidencijaAviona.ViewModel
{
  
    public class DodavanjeNovogAvionaViewModelFactory : EvidencijaAviona.ViewModel.IDodavanjeNovogAvionaViewModelFactory
    {
        private static DodavanjeNovogAvionaViewModelFactory _f = null;

        public static DodavanjeNovogAvionaViewModelFactory getInstance()
        {
            if (_f == null) _f = new DodavanjeNovogAvionaViewModelFactory();
            return _f;
        }

        private DodavanjeNovogAvionaViewModelFactory()
        {

        }

        public IDodavanjeNovogAvionaViewModel getModel(IMainWindowViewModel model, Model.IAvion av)
        {
            IDodavanjeNovogAvionaViewModel vm = new DodavanjeNovogAvionaViewModel(model, av);
            return vm;
        }
    }
}
