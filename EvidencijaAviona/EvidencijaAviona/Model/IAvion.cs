using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Imaging;

namespace EvidencijaAviona.Model
{
    public interface IAvion
    {
        Guid Oznaka { get; set; }
        String Oznaka1 { get; set; }
        int Oznaka2 { get; set; }
        String Kljuc { get; set; }
        int Tezina { get; set; }
        int BrClanovaPosade { get; set; }
        DateTime DatTehPregled { get; set; }
        Boolean SpremanZaLet { get; set; }
        String TipAviona { get; set; }
        int TeretKapac { get; set; }
        int MaxBrPutnika { get; set; }
        List<String> Posada { get; set; }
        int MaxBrzina { get; set; }
        List<Let> Letovi { get; set; }
        String Status { get; set; } 
        String Slika { get; set; }
        bool IsSelected { get; set; }
        //  BitmapImage Slika { get; set; }
    }
}
