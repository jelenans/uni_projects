using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EvidencijaAviona.Commands;
using System.Windows.Input;

namespace EvidencijaAviona.ViewModel
{
    
    public class DodavanjeNovogAvionaViewModel : IDodavanjeNovogAvionaViewModel
    {
        protected IMainWindowViewModel _vm = null;
        protected DodavanjeNovogAvionaDodavanjeCommand _dodavanje = null;
        protected Model.IAvion avi = null;

        public DodavanjeNovogAvionaViewModel(IMainWindowViewModel vm, Model.IAvion avioon)
        {
            _vm = vm;
            _dodavanje = new DodavanjeNovogAvionaDodavanjeCommand(this);
            
            if (avioon != null)
            {
                avi = _vm.ActiveAvionFactory.newEmptyAvion();
            }
            else
            {
                avi = avioon;
            }
        }

        public Model.IAvion TrenutniAvion
        {
            get
            {
                return avi;
            }
            set
            {
                avi = value;
            }
        }

        public IMainWindowViewModel MainWindowModel
        {
            get
            {
                return _vm;
            }
            set
            {
                _vm = value;
            }
        }

        public ICommand DodavanjeCommand
        {
            get
            {
                return _dodavanje;
            }
        }
 
        public event CloseTriggerEventHandler CloseTriggerEvent;

        public void CloseTrigger()
        {
            if (CloseTriggerEvent != null)
            {
                CloseTriggerEvent(this);
            }
        }



    }
}
