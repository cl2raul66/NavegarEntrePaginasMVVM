using PaginasMVVM.Vistas;
using PaginasMVVM.VistasModelo;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PaginasMVVM.Servicios
{
    public interface INavegacionServicio
    {
        Task Ir<T>();
        Task IrConModal<T>();
        Task Regresar();
        Task RegresarDelModal();
    }

    public class NavegacionServicio : INavegacionServicio
    {
        public async Task Ir<T>()
        {            
            await Application.Current.MainPage.Navigation.PushAsync(GetPage(typeof(T)), true); 
        }

        public async Task IrConModal<T>()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(GetPage(typeof(T)), true);
        }

        public async Task Regresar()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }

        public async Task RegresarDelModal()
        {
            await Application.Current.MainPage.Navigation.PopModalAsync();
        }

        #region Extra
        private Page GetPage(Type type)
        {
            Page Resul = new Principal();
            if (object.ReferenceEquals(type, typeof(AjustesVistaModelo)))
            {
                Resul = new Ajustes();
            }
            if (object.ReferenceEquals(type, typeof(Operaciones1VistaModelo)))
            {
                Resul = new Operaciones1();
            }
            if (object.ReferenceEquals(type, typeof(Operaciones2VistaModelo)))
            {
                Resul = new Operaciones2();
            }
            return Resul;
        }
        #endregion
    }
}
