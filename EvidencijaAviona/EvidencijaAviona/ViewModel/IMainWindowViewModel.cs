using System;
using System.Windows.Input;
namespace EvidencijaAviona.ViewModel
{
    public delegate void DodavanjeEventHandler(object sender, IDodavanjeNovogAvionaViewModel model);
    public delegate void IzmenaEventHandler(object sender, IIzmenaAvionaViewModel model);
   
    public interface IMainWindowViewModel
    {

        event DodavanjeEventHandler DodavanjeEvent;
        event IzmenaEventHandler IzmenaEvent;
        ICommand Brisanje { get; }
        ICommand Dodavanje { get; }
        ICommand Izmena { get; }
        EvidencijaAviona.Model.IAvioniKolekcija Repository { get; }
        EvidencijaAviona.Model.IAvionFactory ActiveAvionFactory { get; }
        IDodavanjeNovogAvionaViewModelFactory DNRViewModelFactory { get; }
        IIzmenaAvionaViewModelFactory IAViewModelFactory { get; }
        EvidencijaAviona.Model.IAvion Selected { get; set; }
        IDodavanjeNovogAvionaViewModel DodavanjeModel { get; }
        IIzmenaAvionaViewModel IzmenaModel { get; }
        void dodavanjeNovogAviona(IDodavanjeNovogAvionaViewModel model);
        void izmenaAviona(IIzmenaAvionaViewModel model);
        
    }
}
