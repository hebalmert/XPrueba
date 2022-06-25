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
    public partial class Producto : ContentPage
    {
        //public List<ProductoCLS> listaproductos { get; set; }

        public EnitiesCLS oEnitiesCLS { get; set; }
        public string nombreProducto { get; set; }

        //propiedad privada para poder hacer el filtrado
        private List<ProductoCLS> lista;
        public Producto()
        {
            InitializeComponent();
            oEnitiesCLS = new EnitiesCLS();
            oEnitiesCLS.listaProducto = new List<ProductoCLS>();

            oEnitiesCLS.listaProducto.Add(new ProductoCLS{ nombre="Inka Cola", precio= 8.5, stock= 20 , nombreCategoria="Gaseosa"});
            oEnitiesCLS.listaProducto.Add(new ProductoCLS { nombre = "Coca Cola", precio = 7.3, stock = 11, nombreCategoria = "Gaseosa" });
            oEnitiesCLS.listaProducto.Add(new ProductoCLS { nombre = "Soda", precio = 1.3, stock = 35, nombreCategoria = "Galletas" });
            oEnitiesCLS.listaProducto.Add(new ProductoCLS { nombre = "Galleta de Agua", precio = 1, stock = 8, nombreCategoria = "Gaseosa" });

            BindingContext = this;

            lista = oEnitiesCLS.listaProducto;
        }

        private void searchProducto_SearchButtonPressed(object sender, EventArgs e)
        {
            SearchBar obj = sender as SearchBar;
            string texto = obj.Text;
            if (texto != String.Empty)
            {
                oEnitiesCLS.listaProducto = lista.Where(p => p.nombre.ToLower().Contains(texto.ToLower())).ToList();
            }
            else
            {
                oEnitiesCLS.listaProducto = lista;
            }
            //DisplayAlert("Aviso", texto, "Aceptar");
        }

        private void toolbarAgregarProducto_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FormProducto(new ProductoCLS(), "Agregar Producto"));
        }

        private void lstProducto_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ProductoCLS objProducto = (ProductoCLS)e.SelectedItem;
            Navigation.PushAsync(new FormProducto(objProducto, "Editar Producto"));
        }
    }
}