using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MiPrimer.ViewPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistroUsuarios : ContentPage
    {
        public RegistroUsuarios()
        {
            InitializeComponent();
        }

        private async void volverLogin_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }


        //Entry y Editor( .text)
        //DatePiker ( .Date )
        private void btnRegistrarUsuarios_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Alerta", "Nombre: " + txtnombre.Text +
                "Fecha: " + txtNacimiento.Date +
                "Detalle: " + txtDetalles.Text, "Cancelar");
        }
    }
}