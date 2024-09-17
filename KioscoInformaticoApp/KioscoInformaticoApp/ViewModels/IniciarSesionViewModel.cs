using KioscoInformaticoApp.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoInformaticoApp.ViewModels
{
    public class IniciarSesionViewModel : ObjectNotification
    {
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private bool recordarContraseña;
        public bool RecordarContraseña
        {
            get { return recordarContraseña;}
            set { recordarContraseña = value; }

        }
    }
}
