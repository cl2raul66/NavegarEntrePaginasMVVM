using System.Threading.Tasks;
using Xamarin.Forms;

namespace PaginasMVVM.Utiles
{
    public class Navegacion
    {
        public static async Task Ir(ContentPage contentPage)
        {
            await Application.Current.MainPage.Navigation.PushAsync(contentPage, true);
        }

        public static async Task Regresar()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }

        public static async Task IrConModal(ContentPage contentPage)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(contentPage, true);
        }

        public static async Task RegresarDelModal()
        {
            await Application.Current.MainPage.Navigation.PopModalAsync();
        }
    }
}
