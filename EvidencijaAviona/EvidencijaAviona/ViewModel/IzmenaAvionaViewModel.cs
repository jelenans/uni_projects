using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EvidencijaAviona.Commands;
using System.Windows.Input;

namespace EvidencijaAviona.ViewModel
{
    
    public class IzmenaAvionaViewModel : IIzmenaAvionaViewModel
    {
        protected IMainWindowViewModel _vm = null;
        protected IzmenaAvionaIzmenaCommand _izmena = null;
        protected Model.IAvion avi = null;//Selected;
     

        public IzmenaAvionaViewModel(IMainWindowViewModel vm, Model.IAvion avioon)
        {
            _vm = vm;
            _izmena = new IzmenaAvionaIzmenaCommand(this);
            if (avioon != null)
            {
              //  avi = _vm.ActiveAvionFactory.newEmptyAvion();
                avi = _vm.ActiveAvionFactory.zaIzmenuAvion(_vm.Selected.Oznaka);
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

        public ICommand IzmenaCommand
        {
            get
            {
                return _izmena;
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
