using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Pokemon
    {

        public int? Id { get; set; }

        public string nombre { get; set; }

        public DateTime fechaCreacion { get; set; }

        public int puntosVida { get; set; }

        public int puntosAtaque { get; set; }

        public int puntosDefensa { get; set; }

        public string tipo { get; set; }

        public string descripcion { get; set; }
    }
}