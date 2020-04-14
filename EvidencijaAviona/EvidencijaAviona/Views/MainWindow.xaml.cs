using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections;
using EvidencijaAviona.Model;
using EvidencijaAviona.ViewModel;

namespace EvidencijaAviona.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      
        private IMainWindowViewModel _vm = null;
        public MainWindow(IMainWindowViewModel vm)
        {
            InitializeComponent();
            _vm = vm;
            _vm.DodavanjeEvent += new DodavanjeEventHandler(_vm_DodavanjeEvent);
            _vm.IzmenaEvent += new IzmenaEventHandler(_vm_IzmenaEvent);
            this.DataContext = _vm;
        }
       
        void _vm_DodavanjeEvent(object sender, IDodavanjeNovogAvionaViewModel model)
        {
            DodavanjeNovogAviona dnr = new DodavanjeNovogAviona(model);
            dnr.ShowDialog();
        }

        void _vm_IzmenaEvent(object sender, IIzmenaAvionaViewModel model)
        {
            IzmenaAviona inr = new IzmenaAviona(model);
            inr.ShowDialog();
        }
   
    }
}
