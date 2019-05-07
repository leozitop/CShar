using Escola_de_Rock.Interfaces;

namespace Escola_de_Rock.Models
{
    public class Contrabaixo : InstrumentoMusical, IPercussao, IHarmonia
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo ritmo como um(a) {0}", this.GetType().Name);
            return true;
        }

        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes como um(a) {0}", this.GetType().Name);
            return true;
        }
    }
}