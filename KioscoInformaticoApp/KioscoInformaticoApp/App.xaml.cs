﻿using KioscoInformaticoApp.Views;

namespace KioscoInformaticoApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new IniciarSesionView());
        }
    }
}
