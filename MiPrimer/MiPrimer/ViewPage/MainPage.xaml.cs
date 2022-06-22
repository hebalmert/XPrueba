using MiPrimer.Clases;
using MiPrimer.ViewPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MiPrimer
{
    public partial class MainPage : ContentPage
    {
        public UsuarioCLS ousuariosCLS { get; set; } = new UsuarioCLS();
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void btnVerMas_Clicked(object sender, EventArgs e)
        {
            string valor = lblTexto.Text;
            //1 ocultas el boton
            btnVerMas.IsVisible = false;
            lblTexto.LineBreakMode = LineBreakMode.WordWrap;
            //Application.Current.MainPage.DisplayAlert("Alerta", "Hola", "Salir");
            //DisplayAlert("Alerta", "Hola A Todos", "Salir");
            //DisplayAlert("Alerta", valor, "Salir");
        }

        private async void btbRegistrar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistroUsuarios());
        }

        private async void toolbarAgregar_Clicked(object sender, EventArgs e)
        {
            // con Navigation.PushAsyc se coloca la Flecha de Atras en el Menu Superior
            await Navigation.PushAsync(new RegistroUsuarios());
        }

        private void btbIngresar_Clicked(object sender, EventArgs e)
        {
            if (ousuariosCLS.nombreusuario == "hebalmert" && ousuariosCLS.contra == "123456")
            {
                Application.Current.MainPage = new PaginaPrincipal();
            }
            else
            {
                DisplayAlert("Error", "Usuario o Contrasena Incorrecto", "Aceptar");
            }
        }

        private void btbAsignar_Clicked(object sender, EventArgs e)
        {
            ousuariosCLS.nombreusuario = "hebalmert";
            ousuariosCLS.contra = "123456";
        }
    }
}
