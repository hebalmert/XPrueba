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
    public partial class FormProducto : ContentPage
    {

        public ProductoCLS oProductoCLS { get; set; }

        //fuent de datos
        public List<string> listacategoria { get; set; }

        public FormProducto(ProductoCLS obj, string titulo)
        {
            InitializeComponent();
            Title = titulo;
            listacategoria = new List<string>();
            listacategoria.Add("Gaseosas");
            listacategoria.Add("Galleta");
            //recuperamos la informacion que viene del formulario Producto
            oProductoCLS = obj;
            //oProductoCLS = new ProductoCLS();
            //oProductoCLS.nombreCategoria = "Gaseosa";
            BindingContext = this;
        }
    }
}