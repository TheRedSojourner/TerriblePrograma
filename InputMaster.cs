using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerriblePrograma
{
    internal class InputMaster
    {

        private InputMaster() { }

        private static InputMaster _instance;

        public static InputMaster GetInstance()
        {
            if (_instance == null)
            {
                _instance = new InputMaster();
            }
            return _instance;
        }

        public void LeemeEsteTexto(string texto) 
        {
            Console.WriteLine(texto);
        }

    }
}
