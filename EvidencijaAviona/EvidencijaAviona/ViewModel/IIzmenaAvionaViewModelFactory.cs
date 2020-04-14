using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvidencijaAviona.ViewModel
{
    public interface IIzmenaAvionaViewModelFactory
    {
        IIzmenaAvionaViewModel getModel(IMainWindowViewModel model, EvidencijaAviona.Model.IAvion avion);

       
    }
}
