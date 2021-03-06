using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TreeCensus
{
    public partial class MainPage : ContentPage
    {
        Censo censo = null;
        bool _LugarDisponible = true;
        public bool LugarDisponible
        {
            get { return _LugarDisponible; }
            set { _LugarDisponible = value; OnPropertyChanged(); }
        }

        public List<PickerElement> Alturas = new List<PickerElement> {
            new PickerElement(){ Id = 6, Name = "6" },
            new PickerElement(){ Id = 12, Name = "12" },
            new PickerElement(){ Id = 18, Name = "18" },
            new PickerElement(){ Id = 19, Name = "MAS" },
            };


        public MainPage()
        {
            InitializeComponent();
            censo = new Censo();
        }

        private void ParImpar_Toggled(object sender, ToggledEventArgs e)
        {
            censo.EsPar = e.Value;
        }

        private void VeredaConstruida_Toggled(object sender, ToggledEventArgs e)
        {
            censo.TieneVereda = e.Value;
        }

        private void LugarDisponible_Toggled(object sender, ToggledEventArgs e)
        {
            censo.LugarDisponible = e.Value;
            LugarDisponible = e.Value;
            if (!e.Value)
            {
                censo.Cazuela = false;
                censo.Jardin = false;
            }
        }

        public class PickerElement
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
