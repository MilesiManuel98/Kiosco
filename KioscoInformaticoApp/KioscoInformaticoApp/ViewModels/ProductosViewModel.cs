﻿using CommunityToolkit.Mvvm.Messaging;
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

        //https://chatgpt.com/share/9ab527ab-34a6-426c-b7a7-362c38e460a7
        private bool _isRefreshing;
        public bool IsRefreshing
        {
            get => _isRefreshing;
            set
            {
                _isRefreshing = value;
                OnPropertyChanged();
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

        public Command ObtenerProductosCommand { get; }
        public Command FiltrarProductosCommand { get; }
        public Command AgregarProductoCommand { get; }
        public Command AbrirOfertasCommand { get; }

        public ProductosViewModel()
        {
            ObtenerProductosCommand = new Command(async () => await ObtenerProductos());
            FiltrarProductosCommand = new Command(async () => await FiltrarProductos());
            AgregarProductoCommand = new Command(async () => await AgregarProducto());
            AbrirOfertasCommand = new Command(async () => await AbrirOfertas());
            ObtenerProductos();
        }

        private async Task AbrirOfertas()
        {
            WeakReferenceMessenger.Default.Send(new Message("AbrirOfertas"));
        }

        private async Task AgregarProducto()
        {
            WeakReferenceMessenger.Default.Send(new Message("AgregarProducto"));
        }

        private async Task FiltrarProductos()
        {
            var productosFiltrados = productosListToFilter.Where(p => p.Nombre.Contains(filterProducts)).ToList();
            Productos = new ObservableCollection<Producto>(productosFiltrados);
        }
        public async Task ObtenerProductos()
        {
            FilterProducts = string.Empty;
            IsRefreshing = true;
            productosListToFilter = await productoService.GetAllAsync();
            Productos = new ObservableCollection<Producto>(productosListToFilter);
            IsRefreshing = false;
        }
    }
}
