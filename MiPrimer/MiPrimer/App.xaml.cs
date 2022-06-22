using MiPrimer.ViewPage;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MiPrimer
{
    public partial class App : Application
    {
        public static NavigationPage Navigate { get; internal set; }
        public static PaginaPrincipal MenuApp { get; internal set; }

        public App()
        {
            InitializeComponent();

            //indica que pagina arranca
            //new NavigationPage es para que permita navegar de una pagina a otro
            MainPage = new NavigationPage( new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
