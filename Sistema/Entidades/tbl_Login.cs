using System;
namespace Sistema.Entidades
{
    public class tbl_Login
    {
        private int idLogin;
        private string usuario;
        private string contrasena;
        private int empleadoLogin;

        public int IdLogin { get => idLogin; set => idLogin = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public int EmpleadoLogin { get => empleadoLogin; set => empleadoLogin = value; }

        public tbl_Login()
        {
        }
    }
}
