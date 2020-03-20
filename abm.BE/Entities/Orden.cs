using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abm.BE.Entities
{
    public class Orden
    {

        public Orden()
        {
            this.Open = true;
        }

        public int ID { get; set; }
        public string TecTurno { get; set; }
        public string Descripcion { get; set; }
        public string Urgencia { get; set; }

        public bool Open { get; set; }

    }
}
