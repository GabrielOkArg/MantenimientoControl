using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abm.BE.Entities
{
    public class Sector
    {

        public Sector(int p0, string p1, Edificio p2, string p3, string p4)
        {
            this.ID = p0;
            this.Name = p1;
            this.Ubicacion = p2;
            this.Urgencia = p3;
            this.Level = p4;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public Edificio Ubicacion { get; set; }
        public string Urgencia { get; set; }
        public string Level { get; set; }
    }
}
