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

        private void btnGuardarCategoria_Clicked(object sender, EventArgs e)
        {
            Categoria obj = Categoria.GetInstance();
            List<CategoriaCLS> l = obj.oEntitiesCLS.listaCategoria.ToList();
            if (Title == "Nueva Categoria")
            {
                //Agregar
                l.Add(oCategoriaCLS);
               
            }
            else
            {
                //Editar
                int indice = l.FindIndex(p => p.iidcategoria == oCategoriaCLS.iidcategoria);
                l[indice] = oCategoriaCLS;
            }
            obj.oEntitiesCLS.listaCategoria = l;
            Navigation.PopAsync();
        }

        private void btnRegresarCategoria_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}