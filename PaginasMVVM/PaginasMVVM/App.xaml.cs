using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using PaginasMVVM.Servicios;
using PaginasMVVM.Vistas;
using PaginasMVVM.VistasModelo;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PaginasMVVM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Ioc.Default.ConfigureServices(new ServiceCollection()
                .AddSingleton<INavegacionServicio, NavegacionServicio>()
                .AddTransient<PrincipalVistaModelo>()
                .AddTransient<Operaciones1VistaModelo>()
                .AddTransient<Operaciones2VistaModelo>()
                .BuildServiceProvider()
            );

            MainPage = new NavigationPage(new Principal());
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
