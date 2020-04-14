using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvidencijaAviona.Model
{
    public interface IAvioniKolekcija
    {
        void ObrisiAvion(IAvion avion);
        void IzmeniAvion(IAvion aa);
        System.Collections.ObjectModel.ObservableCollection<IAvion> PronadjiSveAvione();
        System.Collections.ObjectModel.ObservableCollection<IAvion> Avioni { get; }
        void SacuvajAvion(IAvion avion);
        IAvion VratiAvionId(Guid avionId);
    }
}
