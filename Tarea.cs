using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba
{
    internal class Tarea
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaLimite { get; set; }
        public bool Completada { get; set; }

        public Tarea(int id, string descripcion, DateTime? fechaLimite = null)
        {
            Id = id;
            Descripcion = descripcion;
            FechaLimite = fechaLimite;
            Completada = false;
        }
    }
}
