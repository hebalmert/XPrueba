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
    public partial class Menu : ContentPage
    {
        public List<MenuCLS> listamenu { get; set; }

        public Menu()
        {
            InitializeComponent();

            listamenu = new List<MenuCLS>();
            listamenu.Add(new MenuCLS { nombreicono = "ic_category", nombreitem = "Categoria" });
            listamenu.Add(new MenuCLS { nombreicono = "ic_product", nombreitem = "Producto" });
            listamenu.Add(new MenuCLS { nombreicono = "ic_cerrar", nombreitem = "Salir" });

            BindingContext = this;
        }

        private void lstMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //Ya tenemos en la variable todo el objeto de la fila seleccionada
            MenuCLS omenuCLS = (MenuCLS)e.SelectedItem;

            switch (omenuCLS.nombreitem)
            {
                case "Categoria": 
                    App.Navigate.PushAsync(new Categoria());
                    break;

                case "Producto": 
                    App.Navigate.PushAsync(new Producto());
                    break;

                case "Salir":
                    App.Current.MainPage = new MainPage();
                    break;
            }
            //Para Cerrar el Menu una vez que se da Click
            App.MenuApp.IsPresented = false;


            //DisplayAlert("Aviso", omenuCLS.nombreicono, "Cancelar");
        }
    }
}