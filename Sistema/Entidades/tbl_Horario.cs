using System;
namespace Sistema.Entidades
{
    public class tbl_Horario
    {
        private int idHorario;
        private string descripcion;
        private int horaEntrada;
        private int horaSalida;

        public int IdHorario { get => idHorario; set => idHorario = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int HoraEntrada { get => horaEntrada; set => horaEntrada = value; }
        public int HoraSalida { get => horaSalida; set => horaSalida = value; }

        public tbl_Horario()
        {
        }
    }
}
