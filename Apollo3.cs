internal class Program
{
    private static void Main(string[] args)
    {
        // Juancito martel
        int totalHierro = 0;
         
        int totalOro = 0;
        Half n = Half.One;
        int totalPlatino = 0;
        int totalMisc = 0;
        string sigueMinando = "si";


        while (sigueMinando != "no")
        {
            int cantidadAsteroidesEnSistema = cantidadAsteroides();
            for (int i = 0; i < cantidadAsteroidesEnSistema; i++)
            {
                AsteroidSize tipoAsteroide = DeterminarTipoAsteroide();
                int[] composicion = ObtenerComposicionAleatoriaBetterer(tipoAsteroide);


                totalHierro += composicion[0];
                totalOro += composicion[1];
                totalPlatino += composicion[2];
                totalMisc += composicion[3];
                Console.WriteLine($"Procesamiento completado en este sistema: se minaron {cantidadAsteroidesEnSistema} ");
                Console.WriteLine($"Hierro: {composicion[0]} kg");
                Console.WriteLine($"Oro: {composicion[1]} kg");
                Console.WriteLine($"Platino: {composicion[2]} kg");
                Console.WriteLine($"Misc: {composicion[3]} kg");

            }
            Console.WriteLine("¿Desea entrar en otro sistema? (Sí/No): ");
            sigueMinando = Console.ReadLine().Trim().ToLower();
            Console.WriteLine($"Procesamiento completado");
            Console.WriteLine($"Hierro: {totalHierro} kg");
            Console.WriteLine($"Oro: {totalOro} kg");
            Console.WriteLine($"Platino: {totalPlatino} kg");
            Console.WriteLine($" Misc: {totalMisc} kg");
        }
    }
    static int cantidadAsteroides() { return new Random().Next(1, 11); }
    

    static AsteroidSize DeterminarTipoAsteroide() {
    
        //Porque no podemos acceder al indice de un enum (no tienen)
        //para sacar un tipo random de un enum tenemos que sacar todos los valores, meterlos en un array
        //y despues sacar uno de esos valores random del array, para despues asignarlo como nuevo enum
        Random randy = new Random();
        Array values = Enum.GetValues(typeof(AsteroidSize));
        int rand = randy.Next(0, Enum.GetNames(typeof(AsteroidSize)).Length);
        int actualEnumNumber = (int)values.GetValue(rand);
        AsteroidSize asteroid = (AsteroidSize)actualEnumNumber;
        return asteroid;


    }

    static int[] ObtenerComposicionAleatoriaBetterer(AsteroidSize tipoAsteroide)
    {
        
        int cantidadDeTamaños = Enum.GetNames(typeof(AsteroidSize)).Length;
        int[] composicion = new int[cantidadDeTamaños];
        int cantDeMinerales = Enum.GetNames(typeof(TipoDeMetales)).Length;
        int mineralesMax = (int)tipoAsteroide;

        Random random = new Random();

        //Itereramos para asignar dinamicamente los minerales en sus respectivas posiciones
        for (int i = 0; i < cantDeMinerales; i++) 
        {
            int minerales = random.Next(0, mineralesMax);
            mineralesMax -= minerales;
            composicion[i] = minerales;
            //si este es el ultimo tipo de mineral, le ponemos todo lo que sobra
            if (i == cantDeMinerales) 
            {
                composicion[i] += mineralesMax;    
            }
        }

        return composicion;

    }
}



enum AsteroidSize
{
    smol = 1000,
    medium = 2000,
    large = 5000,
    huge = 10000
}


enum TipoDeMetales
{
    Hierro,
    Oro,
    Platino,
    Misc
}