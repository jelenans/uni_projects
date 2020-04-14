using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EvidencijaAviona.Model;
using EvidencijaAviona.Commands;
using System.Windows.Input;

namespace EvidencijaAviona.ViewModel
{

    public delegate void CloseTriggerEventHandler(object sender);
    public interface IDodavanjeNovogAvionaViewModel
    {
        IAvion TrenutniAvion { get; set; }
        IMainWindowViewModel MainWindowModel { get; set; }
        ICommand DodavanjeCommand { get; }

        event CloseTriggerEventHandler CloseTriggerEvent;
        void CloseTrigger();



    }
}
