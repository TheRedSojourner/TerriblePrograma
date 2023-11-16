using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerriblePrograma
{
    internal abstract class CuerpoAstral
    {
        protected string sector;
        protected double masa;
        protected string nombre;
        protected List<string> composicion;



        public CuerpoAstral(string sector, double masa, string nombre, List<string> composicion)
        {
            this.sector = sector;
            this.masa = masa;
            this.nombre = nombre;
            this.composicion = composicion;
        }

        public string GetSector() { return sector; }
        public double GetMasa() { return masa; }

        public string GetNombre() { return nombre; }
        public virtual void GetComposicion() { Console.WriteLine("te devuelvo la data, viejo"); }

        public CuerpoAstral() { }
    }
}
