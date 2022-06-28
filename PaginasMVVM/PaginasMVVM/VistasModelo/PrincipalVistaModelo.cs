using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using PaginasMVVM.Servicios;
using PaginasMVVM.Utiles;
using PaginasMVVM.Vistas;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PaginasMVVM.VistasModelo
{
    public class PrincipalVistaModelo : ObservableObject
    {
        public PrincipalVistaModelo()
        {
            AjustesClick = new AsyncRelayCommand(async () =>
            {
                await Ioc.Default.GetService<INavegacionServicio>().Ir<AjustesVistaModelo>();
                //await Navegacion.Ir(new Ajustes());
            });

            Operacion1Click = new AsyncRelayCommand(async () =>
            {
                await Ioc.Default.GetService<INavegacionServicio>().IrConModal<Operaciones1VistaModelo>();
                //await Navegacion.IrConModal(new Operaciones1());
            });

            Operacion2Click = new AsyncRelayCommand(async () =>
            {
                await Ioc.Default.GetService<INavegacionServicio>().IrConModal<Operaciones1VistaModelo>();
                //await Navegacion.IrConModal(new Operaciones2());
            });
        }

        #region Propiedades

        #endregion

        #region Comandos
        public IAsyncRelayCommand AjustesClick { get; }
        public IAsyncRelayCommand Operacion1Click { get; }
        public IAsyncRelayCommand Operacion2Click { get; }
        #endregion
    }
}
