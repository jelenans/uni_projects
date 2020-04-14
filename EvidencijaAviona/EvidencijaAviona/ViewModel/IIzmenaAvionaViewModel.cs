using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EvidencijaAviona.Model;
using EvidencijaAviona.Commands;
using System.Windows.Input;

namespace EvidencijaAviona.ViewModel
{
  
  
    public interface IIzmenaAvionaViewModel
    {
        IAvion TrenutniAvion { get; set; }
        IMainWindowViewModel MainWindowModel { get; set; }
        ICommand IzmenaCommand { get; }

        event CloseTriggerEventHandler CloseTriggerEvent;
        void CloseTrigger();


    }
}
