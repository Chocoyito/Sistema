using System;
namespace Sistema.Entidades
{
    public class tbl_EmpleadoLogin
    {
        public int empleadoLogin;
        public int idLogin;

        public tbl_EmpleadoLogin(int empleadoLogin, int idLogin)
        {
            this.empleadoLogin = empleadoLogin;
            this.idLogin = idLogin;
        }

        public tbl_EmpleadoLogin()
        {
        }
    }
}
