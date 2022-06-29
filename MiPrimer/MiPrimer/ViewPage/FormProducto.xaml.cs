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

        public string titulo { get; set; }
        //fuent de datos
        public List<string> listacategoria { get; set; }

        public FormProducto(ProductoCLS obj, string nombretitulo)
        {
            InitializeComponent();
            titulo = nombretitulo;
            listacategoria = new List<string>();
            listacategoria.Add("Gaseosas");
            listacategoria.Add("Galleta");
            //recuperamos la informacion que viene del formulario Producto
            oProductoCLS = obj;
            //oProductoCLS = new ProductoCLS();
            //oProductoCLS.nombreCategoria = "Gaseosa";
            BindingContext = this;
        }

        private void btnGuardarProducto_Clicked(object sender, EventArgs e)
        {
            Producto obj = Producto.GetInstance();
            List<ProductoCLS> l = obj.oEnitiesCLS.listaProducto.ToList();
            if (Title == "Agregar Producto")
            {
                //Agregar
                l.Add(oProductoCLS);

            }
            else
            {
                //Editar
                int indice = l.FindIndex(p => p.IdProducto == oProductoCLS.IdProducto);
                l[indice] = oProductoCLS;
            }
            obj.oEnitiesCLS.listaProducto = l;
            Navigation.PopAsync();
        }

        private void btnRegresarPoducto_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}