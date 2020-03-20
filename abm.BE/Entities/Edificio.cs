using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abm.BE.Entities
{
    public class Edificio
    {


        public Edificio(string p0,int p1,string p2, int p3, string p4)
        {
            this.Name = p0;
            this.ID = p1;
            this.Calle = p2;
            this.Numero = p3;
            this.Localidad = p4;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
        public string Localidad { get; set; }
    }
}
