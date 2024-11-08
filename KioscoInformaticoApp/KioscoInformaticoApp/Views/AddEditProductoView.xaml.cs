using KioscoInformaticoApp.ViewModels;
using KioscoInformaticoServices.Models;

namespace KioscoInformaticoApp.Views;

[QueryProperty(nameof(Product), "ProductToEdit")]
public partial class AddEditProductoView : ContentPage
{
	public AddEditProductoView()
	{
		InitializeComponent();
	}
    public AddEditProductoView(Producto producto)
    {
        InitializeComponent();
        var viewModel = this.BindingContext as AddEditProductoViewModel;
        viewModel.EditProduct = producto;
    }

    public Producto Product
    {
        set
        {
            var viewModel = this.BindingContext as AddEditProductoViewModel;
            viewModel.EditProduct = value;
        }
    }
}