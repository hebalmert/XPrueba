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

        public List<CategoriaCLS> listaCategoria { get; set; }

        public Categoria()
        {
            InitializeComponent();
            listaCategoria = new List<CategoriaCLS>();
            listaCategoria.Add(new CategoriaCLS { IdCategory = 1, 
                nombre="Gaseossa", 
                descripcion="Para todos los gustos de y sabores"});
            listaCategoria.Add(new CategoriaCLS { IdCategory = 2,
                nombre = "Galletas", 
                descripcion = "Hechas con mucha harina y para grandes y chicos" });

            // Para que el codigo Xaml conozca el valor de la propiedas listacategoria
            BindingContext = this;
        }

        private void lstCategoria_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            CategoriaCLS objCategoria = (CategoriaCLS)e.SelectedItem;
            Navigation.PushAsync(new FormCategoria(objCategoria));
        }
    }
}