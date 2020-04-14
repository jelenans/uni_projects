using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EvidencijaAviona.Model;
using EvidencijaAviona.Commands;
using System.Windows.Input;

namespace EvidencijaAviona.ViewModel
{
   
    public class MainWindowViewModel : EvidencijaAviona.ViewModel.IMainWindowViewModel
    {
        protected TabelaBrisanjeCommand _brisanje = null;
        protected TabelaDodavanjeCommand _dodavanje = null;
        //....................................................
        protected TabelaIzmenaCommand _izmena = null;
        //....................................................


       
        public MainWindowViewModel(IAvioniKolekcija kolek, IAvionFactory afact, IDodavanjeNovogAvionaViewModelFactory dnafact, IIzmenaAvionaViewModelFactory ifact)
        {
            _brisanje = new TabelaBrisanjeCommand(this);
            _dodavanje = new TabelaDodavanjeCommand(this);
            _izmena = new TabelaIzmenaCommand(this);
            this.aviKol = kolek;
            this.aviFact = afact;
            this.anrfact = dnafact;
            this.izmfact = ifact;
        }

        protected virtual void OnDodavanje(IDodavanjeNovogAvionaViewModel model)
        {
            if (Dodavanje != null)
            {
                DodavanjeEvent(this, model);
            }
        }
        //..........................................................
        protected virtual void OnIzmena(IIzmenaAvionaViewModel model)
        {
            if (Izmena != null)
            {
                IzmenaEvent(this, model);
            }
        }
        //...........................................................
        
        public ICommand Brisanje { 
            get
            {
                return _brisanje;
            } 
        }
       
        public ICommand Dodavanje
        {
            get
            {
                return _dodavanje;
            }
        }

        //................................................................
        public ICommand Izmena
        {
            get
            {
                return _izmena;
            }
        }
        //................................................................


       
        public IAvion Selected { get; set; }

      
        private IAvioniKolekcija aviKol = null;
       
        private IAvionFactory aviFact = null;
       
        private IDodavanjeNovogAvionaViewModelFactory anrfact = null;
        //................................................................

        private IIzmenaAvionaViewModelFactory izmfact = null;
        //................................................................
        
        public IAvioniKolekcija Repository { get { return aviKol; } }
        public IAvionFactory ActiveAvionFactory { get { return aviFact; } }

        public event DodavanjeEventHandler DodavanjeEvent;
        public event IzmenaEventHandler IzmenaEvent;

        
        public IDodavanjeNovogAvionaViewModel DodavanjeModel
        {
            get
            {
                return anrfact.getModel(this, this.Selected);
            }
        }

        //........................................................
        public IIzmenaAvionaViewModel IzmenaModel
        {
            get
            {
                return izmfact.getModel(this, this.Selected);
            }
        }
        //........................................................


       
        public void dodavanjeNovogAviona(IDodavanjeNovogAvionaViewModel model)
        {
            OnDodavanje(model);
        }

        //........................................................
        public void izmenaAviona(IIzmenaAvionaViewModel model)
        {
            OnIzmena(model);
        }

       
        //........................................................
       

        public IDodavanjeNovogAvionaViewModelFactory DNRViewModelFactory
        {
            get { return anrfact; }
        }
        //...................................................................
        public IIzmenaAvionaViewModelFactory IAViewModelFactory
        {
            get { return izmfact; }
        }
        //..................................................................
    }
}
