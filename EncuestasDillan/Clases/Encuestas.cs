using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EncuestasDillan.Clases
{
    public class Encuestas
    {
        public int numeroencuesta { get; set; }
        public string nombre { get; set; }
        public string fechanacimiento { get; set; }
        public string correoelectronico { get; set; }
        public string partidopolitico { get; set; }

        public Encuestas(int numeroencuesta, string nombre, string fechanacimiento, string correoelectronico, string partidopolitico)
        {
            this.numeroencuesta = numeroencuesta;
            this.nombre = nombre;
            this.fechanacimiento = fechanacimiento;
            this.correoelectronico = correoelectronico;
            this.partidopolitico = partidopolitico;
        }

        public void Agregar() { }
        public void Consultar() { }


    }
}