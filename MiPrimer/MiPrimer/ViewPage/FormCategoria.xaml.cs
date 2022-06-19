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

        //Recibimos parametros de Categoria.xaml
        public FormCategoria(CategoriaCLS obj)
        {
            InitializeComponent();
            oCategoriaCLS = obj;
            BindingContext = this;
        }
    }
}