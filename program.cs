using TerriblePrograma;

internal class Program
{
    private static void Main(string[] args)
    {


  
        Luna luna = new Luna();
        Cometa cometa = new Cometa();
        Cometa cometoide = new Cometa();
        Asteroide asteroide = new Asteroide();
        Planeta planeta = new Planeta();




        




        string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

        StreamReader reader = new StreamReader("derp.txt");
        Console.WriteLine(reader.ReadToEnd());



        try
        {
            StreamReader sr = new StreamReader(path + "\\.gitattributes");
            Console.WriteLine(sr.ReadToEnd());
            
        }
        catch (IOException x)
        {
            Console.WriteLine(x.Message);
            
        }






        //InputMaster input = InputMaster.GetInstance();
        //input.LeemeEsteTexto("Este es un texto");



    }

}