using Escola_de_Rock.Interfaces;

namespace Escola_de_Rock.Models
{
    public class Guitarra : InstrumentoMusical, IMelodia, IHarmonia
    {
        public bool TocarSolo()
        {
            System.Console.WriteLine("Tocando solo como um(a) {0}", this.GetType().Name);
            return true;
        }

        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes como um(a) {0}", this.GetType().Name);
            return true;
        }  
    }
}