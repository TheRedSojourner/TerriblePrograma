using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerriblePrograma
{
    class Asteroide : CuerpoAstral
    {
        tamañoAsteroide tamaño;
        int[] pesoMineralesPorTipo;
        List<int> numeros;

        public Asteroide(tamañoAsteroide tamaño) : base()
        {
            
            numeros = new List<int>();
            this.tamaño = tamaño;
            CreameUnAsteroideRandom();
            masa = DeterminarMasaSegunTamaño();
        }

        private double DeterminarMasaSegunTamaño() 
        {
            return 2.0;
        }
        
        public Asteroide() 
        {
            CreameUnAsteroideRandom();
        }


        private void CreameUnAsteroideRandom() 
        {
            tamaño = DeterminarTamañoAsteroide();
            pesoMineralesPorTipo = DeterminarPesosDeMinerales();
            //pesoMineralesPorTipo = AsignarMineralesPorTipo();


        }


        private int[] DeterminarPesosDeMinerales() 
        {
            int[] pesos;
            pesos = new int[Enum.GetValues(typeof(MineralesTipo)).Length];
            return pesos;
        }

        /*private int[] AsignarMineralesPorTipo() 
        {
            int[] pesos;

            return pesos;
        }*/



        public void Explotar() 
        {
        
        }

        private tamañoAsteroide DeterminarTamañoAsteroide() 
        {
            Random randy = new Random();
            tamañoAsteroide tamaño;
            Array tamaños = Enum.GetValues(typeof(tamañoAsteroide));
            int tamañoActual = randy.Next(tamaños.Length);
            tamaño = (tamañoAsteroide)tamañoActual;
            return tamaño;
        }


    }
}
