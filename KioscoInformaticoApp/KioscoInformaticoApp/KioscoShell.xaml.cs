using CommunityToolkit.Mvvm.Messaging;
using KioscoInformaticoApp.Class;
using KioscoInformaticoApp.ViewModels;

namespace KioscoInformaticoApp
{
    public partial class KioscoShell : Shell
    {
        public KioscoShell()
        {
            InitializeComponent();
            FlyoutItemsPrincipal.IsVisible = false;
        }

        public void EnableAppAfterLogin()
        {
            FlyoutBehavior = FlyoutBehavior.Flyout; // Habilita el FlyOut
            FlyoutItemsPrincipal.IsVisible = true; // Muestra el menú lateral
            Shell.Current.GoToAsync("//MainPage"); // Navega a la página principal
            var viewmodel = this.BindingContext as KioscoShellViewModel;
            viewmodel.IsUserLogout = false;
        }
        public void DisableAppAfterLogin()
        {
            FlyoutBehavior = FlyoutBehavior.Disabled; // Deshabilita el FlyOut
            FlyoutItemsPrincipal.IsVisible = false; // Oculta el menú lateral
            Shell.Current.GoToAsync("//Login"); // Navega a la página de login
        }
    }
}
