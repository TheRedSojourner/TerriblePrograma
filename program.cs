
using TerriblePrograma;

internal class Program
{
    private static void Main(string[] args)
    {

        Asteroide[] asteroides = new Asteroide[10];

        for (int i = 0; i < asteroides.Length; i++)
        {
            asteroides[i] = new Asteroide();
            asteroides[i].CreameUnAsteroideRandom();
        }


    }
}