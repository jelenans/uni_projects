using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace EvidencijaAviona
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //Ova funkcija je odgovorna za pokretanje aplikacije. 
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            //Prvo se kreira ViewModel za MainWindow. Ovo je jedino mesto u programu gde se ne koristi interfejs za pristup ostalim elementima aplikacije. To znači da u slučaju, recimo, testiranja ili zamene delova
            //jedini rez mora da se napravi ovde. Ostatak aplikacije je več tako konstruisan da se pozadinske klase mogu izmeniti, a da se ne dira ni jedna linija koda, dok god se ispoštuju ugovori o ponašanju
            //koje predstavljaju interfejsi. 
            EvidencijaAviona.ViewModel.IMainWindowViewModel vm = new EvidencijaAviona.ViewModel.MainWindowViewModel(EvidencijaAviona.Model.AvioniKolekcija.getInstance(), EvidencijaAviona.Model.AvionFactory.getInstance(), EvidencijaAviona.ViewModel.DodavanjeNovogAvionaViewModelFactory.getInstance(), EvidencijaAviona.ViewModel.IzmenaAvionaViewModelFactory.getInstance());
            EvidencijaAviona.Views.MainWindow mw = new EvidencijaAviona.Views.MainWindow(vm);
            mw.Show();
        }
    }
}
