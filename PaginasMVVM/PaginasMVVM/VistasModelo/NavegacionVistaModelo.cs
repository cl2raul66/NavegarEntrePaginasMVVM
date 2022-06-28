using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PaginasMVVM.Vistas;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PaginasMVVM.VistasModelo
{
    public class NavegacionVistaModelo : ObservableObject
    {
        public NavegacionVistaModelo()
        {
            Paginas = new ObservableCollection<ContentPage>
            {
                new Principal(), new Ajustes(), new Operaciones1(), new Operaciones2()
            };
        }

        #region Propiedades
        private ObservableCollection<ContentPage> paginas;
        public ObservableCollection<ContentPage> Paginas
        {
            get => paginas; 
            set => SetProperty(ref paginas, value);
        }

        private ContentPage currentPagina;
        public ContentPage CurrentPagina
        {
            get => currentPagina;
            set => SetProperty(ref currentPagina, value);
        }
        #endregion

        #region Comandos

        #endregion

        #region Extra
        public async Task Ir(ContentPage contentPage)
        {
            await Application.Current.MainPage.Navigation.PushAsync(contentPage, true);
        }

        public async Task Regresar()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }

        public async Task IrConModal(ContentPage contentPage)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(contentPage, true);
        }

        public async Task RegresarDelModal()
        {
            await Application.Current.MainPage.Navigation.PopModalAsync();
        }
        #endregion
    }
}
