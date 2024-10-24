using CommunityToolkit.Mvvm.Messaging;
using KioscoInformaticoApp.Utils;
using KioscoInformaticoApp.ViewModels;

namespace KioscoInformaticoApp.Views;

public partial class IniciarSesionView : ContentPage
{
    public IniciarSesionView()
    {
        InitializeComponent();
        //BindingContext = new IniciarSesionViewModel();
        WeakReferenceMessenger.Default.Register<Message>(this, (r, mensaje) =>
        {
            OnReceiveMessage(mensaje);
        });
    }

    private async void OnReceiveMessage(Message mensaje)
    {
        if (mensaje.Value == "AbrirProductos")
        {
            await Navigation.PushAsync(new ProductosView());
        }
        if (mensaje.Value == "AbrirOfertas")
        {
            await Navigation.PushAsync(new ProductosView());
        }
        if (mensaje.Value == "AgregarProducto")
        {
            await Navigation.PushAsync(new AddEditProductoView());
        }
        if (mensaje.Value == "CerrarVentana")
        {
            await Navigation.PopAsync();
        }
    }
}