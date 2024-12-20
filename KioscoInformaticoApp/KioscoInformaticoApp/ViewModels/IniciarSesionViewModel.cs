﻿using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Firebase.Auth.Repository;
using Firebase.Auth;
using KioscoInformaticoApp.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using Firebase.Auth.Providers;

namespace KioscoInformaticoApp.ViewModels
{
    public partial class IniciarSesionViewModel : ObservableObject
    {
        public readonly FirebaseAuthClient _clientAuth;
        private FileUserRepository _userRepository;
        private UserInfo _userInfo;
        private FirebaseCredential _firebaseCredential;
        
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(IniciarSesionCommand))]
        private string email;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(IniciarSesionCommand))]
        private string password;

        [ObservableProperty]
        private bool recordarContraseña;

        public IRelayCommand IniciarSesionCommand { get; }
        public IRelayCommand RegistrarseCommand { get; }

        public IniciarSesionViewModel()
        {
            _clientAuth = new FirebaseAuthClient(new FirebaseAuthConfig()
            {
                ApiKey = "AIzaSyDfBRLNQh21PbJeBmWHkmU4ntaXnx7lLrQ",
                AuthDomain = "kioscoinformatico-e66aa.firebaseapp.com",
                Providers = new Firebase.Auth.Providers.FirebaseAuthProvider[]
    {
                    new EmailProvider()
    }
            });
            _userRepository = new FileUserRepository("KioscoInformaticoApp");
            ChequearSiHayUsuarioAlmacenado();

            IniciarSesionCommand = new RelayCommand(IniciarSesion, PermitirIniciarSesion);
            RegistrarseCommand = new RelayCommand(Registrarse);
        }

        private async void Registrarse()
        {
            await Shell.Current.GoToAsync("Registrarse");
        }

        private async void ChequearSiHayUsuarioAlmacenado()
        {
            if (_userRepository.UserExists())
            {
                (_userInfo, _firebaseCredential) = _userRepository.ReadUser();

                var shellKiosco = (KioscoShell)App.Current.MainPage;
                shellKiosco.EnableAppAfterLogin();
            }
        }

        private bool PermitirIniciarSesion()
        {
            return !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Password);
        }

        private async void IniciarSesion()
        {
            try
            {

                var userCredential = await _clientAuth.SignInWithEmailAndPasswordAsync(email, password);
                if (userCredential.User.Info.IsEmailVerified == false)
                {
                    await Application.Current.MainPage.DisplayAlert("Inicio de sesión", "Debe verificar su correo electrónico", "Ok");
                    return;
                }

                if (recordarContraseña)
                {
                    _userRepository.SaveUser(userCredential.User);
                }
                else
                {
                    _userRepository.DeleteUser();
                }

                var shellKiosco = (KioscoShell)App.Current.MainPage;
                shellKiosco.EnableAppAfterLogin();

            }
            catch (FirebaseAuthException error)
            {
                await Application.Current.MainPage.DisplayAlert("Inicio de sesión", "Ocurrió un problema:" + error.Reason, "Ok");

            }
  
        }
    }
}
