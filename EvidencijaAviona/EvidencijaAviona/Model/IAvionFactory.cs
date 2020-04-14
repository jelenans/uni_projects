using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvidencijaAviona.Model
{
    public interface IAvionFactory
    {
        IAvion newEmptyAvion();
        IAvion zaIzmenuAvion(Guid avOznk);
    }
}
