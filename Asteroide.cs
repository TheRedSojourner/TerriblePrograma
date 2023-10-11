using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerriblePrograma
{
    class Asteroide
    {
        tamañoAsteroide tamaño;
        int[] pesoMineralesPorTipo;

        public void CreameUnAsteroideRandom() 
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
