using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MiPrimer
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    //Cambiamo la herencia de ContentePage a MarterDetailPage
    public partial class PaginaPrincipal : MasterDetailPage
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
            App.Navigate = Navigation;
        }
    }
}