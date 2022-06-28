using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using PaginasMVVM.Utiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaginasMVVM.VistasModelo
{
    public class Operaciones1VistaModelo : ObservableObject
    {
        public Operaciones1VistaModelo()
        {
            CerrarClick = new AsyncRelayCommand(async () =>
            {
                //await Ioc.Default.GetService<NavegacionVistaModelo>().RegresarDelModal();
                await Navegacion.RegresarDelModal();
            });
        }

        #region Propiedades

        #endregion

        #region Comandos
        public IAsyncRelayCommand CerrarClick { get; }
        #endregion
    }
}
