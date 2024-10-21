using KioscoInformaticoApp.Class;
using KioscoInformaticoServices.Models;
using KioscoInformaticoServices.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoInformaticoApp.ViewModels
{
    public class ProductosViewModel : ObjectNotification
    {
		private GenericService<Producto> productoService = new GenericService<Producto>();
        private string filterProducts;

		public string FilterProducts
        {
			get { return filterProducts; }
			set { filterProducts = value;
                OnPropertyChanged();
                _ = FiltrarProductos();
            }
		}

		private ObservableCollection<Producto> productos;
		public ObservableCollection<Producto> Productos
		{
			get { return productos; }
			set { productos = value; 
				OnPropertyChanged();
            }
		}
        private List<Producto>? productosListToFilter;

        private bool activityStart;
        public bool ActivityStart
        {
            get { return activityStart; }
            set 
            {
                activityStart = value; 
                OnPropertyChanged(); 
            }
        }

        public Command ObtenerProductosCommand { get; }
        public Command FiltrarProductosCommand { get; }

        public ProductosViewModel()
        {
            ObtenerProductosCommand = new Command(async () => await ObtenerProductos());
            FiltrarProductosCommand = new Command(async () => await FiltrarProductos());
        }


        private async Task FiltrarProductos()
        {
            var productosFiltrados = productosListToFilter.Where(p => p.Nombre.Contains(filterProducts)).ToList();
            Productos = new ObservableCollection<Producto>(productosFiltrados);
        }
        private async Task ObtenerProductos()
        {
            ActivityStart = true;
            productosListToFilter = await productoService.GetAllAsync();
            Productos = new ObservableCollection<Producto>(productosListToFilter);
            ActivityStart = false;
        }
    }
}
