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
using System.Windows.Shapes;
using EvidencijaAviona.Model;
using EvidencijaAviona.ViewModel;
using Microsoft.Win32;

namespace EvidencijaAviona.Views
{
    /// <summary>
    /// Interaction logic for DodavanjeNovogAviona.xaml
    /// </summary>
    public partial class DodavanjeNovogAviona : Window
    {
        private IDodavanjeNovogAvionaViewModel _vm = null;
        public DodavanjeNovogAviona(IDodavanjeNovogAvionaViewModel vm)
        {
            InitializeComponent();
            _vm = vm;
            _vm.CloseTriggerEvent += new CloseTriggerEventHandler(_vm_CloseTriggerEvent);
            this.DataContext = _vm;
        }

        void _vm_CloseTriggerEvent(object sender)
        {
            this.Close();
        }
    
   
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "JPEG Image(*.jpg)|*.jpg";
            file.InitialDirectory = "";

            if (file.ShowDialog() == true)
            {
                // string ime = file.FileName;
                img.Source = new BitmapImage(new Uri(file.FileName));
                // image1 = new Image(new BitmapImage(ime), image1.Width, image1.Height);


            }

        }

        private void tbMaxBrPutnika_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

    }
}
