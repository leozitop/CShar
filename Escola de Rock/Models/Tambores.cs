using Escola_de_Rock.Interfaces;

namespace Escola_de_Rock.Models
{
    public class Tambores : InstrumentoMusical, IPercussao
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo ritmo como um(a) {0}", this.GetType().Name);
            return true;
        }
    }
}