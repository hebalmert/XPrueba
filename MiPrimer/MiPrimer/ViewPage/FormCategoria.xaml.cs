using MiPrimer.Clases;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MiPrimer.ViewPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FormCategoria : ContentPage
    {
        public CategoriaCLS oCategoriaCLS { get; set; } = new CategoriaCLS();

        public string Titles { get; set; }

        //Recibimos parametros de Categoria.xaml
        public FormCategoria(CategoriaCLS obj, string titulo)
        {
            InitializeComponent();
            oCategoriaCLS = obj;
            Titles = titulo;
            BindingContext = this;
        }

        private async void btnGuardarCategoria_Clicked(object sender, EventArgs e)
        {
            Categoria obj = Categoria.GetInstance();
            List<CategoriaCLS> l = obj.oEntitiesCLS.listaCategoria.ToList();

            string servicePrefix = "/api";
            string controller = "/Categoria/";

            string url = $"{servicePrefix}{controller}";
            string urlBase = App.Current.Resources["UrlAPI"].ToString();

            HttpClient cliente = new HttpClient()
            {
                BaseAddress = new Uri(urlBase)
            };

            int rpta = await Helpers.Generic.guardarGeneric<CategoriaCLS>(urlBase, url, oCategoriaCLS);

            if (rpta == 0)
            {
                await App.Current.MainPage.DisplayAlert("Error", "Error al Crear o Modificar el Registro", "Aceptar");
                return;
            }
            else
            {
                obj.listarCategorias();
                await Navigation.PopAsync();
            }
            return;


            //if (Title == "Nueva Categoria")
            //{
            //    //Agregar
            //    l.Add(oCategoriaCLS);

            //}
            //else
            //{
            //    //Editar
            //    int indice = l.FindIndex(p => p.iidcategoria == oCategoriaCLS.iidcategoria);
            //    l[indice] = oCategoriaCLS;
            //}
            //obj.oEntitiesCLS.listaCategoria = l;
            //Navigation.PopAsync();
        }

        private void btnRegresarCategoria_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}