using System;
namespace Sistema.Entidades
{
    public class tbl_Registro_Entrada_Y_Salida
    {
        private int idRegistro;
        private DateTime horaDeMarca;
        private int horasExtras;
        int tipoDeMarca; //bit
        private int idEmpleado;
        private int idLogin;

        public int IdRegistro { get => idRegistro; set => idRegistro = value; }
        public DateTime HoraDeMarca { get => horaDeMarca; set => horaDeMarca = value; }
        public int HorasExtras { get => horasExtras; set =>horasExtras = value; }
        public int TipoDeMarca { get => tipoDeMarca; set => tipoDeMarca = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public int IdLogin { get => idLogin; set => idLogin = value; }

        public tbl_Registro_Entrada_Y_Salida()
        {
        }
    }
}
