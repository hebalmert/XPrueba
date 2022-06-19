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
        public List<ProductoCLS> listaproductos { get; set; }

        public Producto()
        {
            InitializeComponent();

            listaproductos = new List<ProductoCLS>();
            listaproductos.Add(new ProductoCLS{ nombre="Inka Cola", precio= 8.5, stock= 20 , nombreCategoria="Gaseosa"});
            listaproductos.Add(new ProductoCLS { nombre = "Coca Cola", precio = 7.3, stock = 11, nombreCategoria = "Gaseosa" });
            listaproductos.Add(new ProductoCLS { nombre = "Soda", precio = 1.3, stock = 35, nombreCategoria = "Galletas" });
            listaproductos.Add(new ProductoCLS { nombre = "Galleta de Agua", precio = 1, stock = 8, nombreCategoria = "Gaseosa" });

            BindingContext = this;
        }
    }
}