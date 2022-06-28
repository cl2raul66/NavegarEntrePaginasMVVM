using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using PaginasMVVM.Servicios;
//using PaginasMVVM.Utiles;

namespace PaginasMVVM.VistasModelo
{
    public class Operaciones1VistaModelo : ObservableObject
    {
        public Operaciones1VistaModelo()
        {
            CerrarClick = new AsyncRelayCommand(async () =>
            {
                await Ioc.Default.GetService<INavegacionServicio>().RegresarDelModal();
                //await Navegacion.RegresarDelModal();
            });
        }

        #region Propiedades

        #endregion

        #region Comandos
        public IAsyncRelayCommand CerrarClick { get; }
        #endregion
    }
}
