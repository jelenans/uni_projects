using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvidencijaAviona.Model
{

    public class AvionFactory : EvidencijaAviona.Model.IAvionFactory
    {
        private static AvionFactory af = null;

        public static AvionFactory getInstance()
        {
            if (af == null)
            {
                af = new AvionFactory();
            }
            return af;
        }

        private AvionFactory()
        {
        }

        public IAvion newEmptyAvion()
        {
            return new Avion();
        }

        public IAvion zaIzmenuAvion(Guid avOznk)
        {
            return AvioniKolekcija.getInstance().VratiAvionId(avOznk);
        }
    }
}
