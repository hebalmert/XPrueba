using MiPrimer.Clases;
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
    public partial class Categoria : ContentPage
    {
        public EnitiesCLS oEntitiesCLS { get; set; }

        //public List<CategoriaCLS> listaCategoria { get; set; }

        public List<CategoriaCLS> lista;

        //implementar paton Singlenton
        public static Categoria instance;

        //Creamos un metodo que nos devuelva la Instancia
        public static Categoria GetInstance() 
        {
            if (instance == null)
            {
                return new Categoria();
            }
            else
            { 
                return instance;
            }
        }


        public Categoria()
        {
            instance = this;

            InitializeComponent();
            oEntitiesCLS = new EnitiesCLS();
            oEntitiesCLS.listaCategoria = new List<CategoriaCLS>();
            oEntitiesCLS.listaCategoria.Add(new CategoriaCLS { IdCategory = 1, 
                nombre="Gaseossa", 
                descripcion="Para todos los gustos de y sabores"});
            oEntitiesCLS.listaCategoria.Add(new CategoriaCLS { IdCategory = 2,
                nombre = "Galletas", 
                descripcion = "Hechas con mucha harina y para grandes y chicos" });

            //Mantiene toda la data
            lista = oEntitiesCLS.listaCategoria;
            // Para que el codigo Xaml conozca el valor de la propiedas listacategoria
            BindingContext = this;
        }

        private void lstCategoria_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            CategoriaCLS objCategoria = (CategoriaCLS)e.SelectedItem;
            Navigation.PushAsync(new FormCategoria(objCategoria, "Editar Categoria"));
        }

        private void toolbarAgregar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FormCategoria(new CategoriaCLS(), "Nueva Categoria"));
        }

        private void menuEliminar_Clicked(object sender, EventArgs e)
        {
            //Se trae por medio del Sender del MenuItem el objeto
            MenuItem oMenuItem = sender as MenuItem;

            //ahora en una variable podemos el objeto completo para manejarlo
            CategoriaCLS oCategoria = (CategoriaCLS)oMenuItem.BindingContext;
            oEntitiesCLS.listaCategoria = oEntitiesCLS.listaCategoria
                .Where(c => c.IdCategory != oCategoria.IdCategory).ToList();
            DisplayAlert("Aviso", oCategoria.nombre, "Aceptar");
        }

        private void SearchCategoria_TextChanged(object sender, TextChangedEventArgs e)
        {
            string valor = e.NewTextValue;
            if (valor == "")
            {
                oEntitiesCLS.listaCategoria = lista;
            }
            else
            {
                oEntitiesCLS.listaCategoria = lista.Where(p => p.nombre.Contains(valor)).ToList();
            }



            //DisplayAlert("Tipeado", valor , "Aceptar");
        }
    }
}