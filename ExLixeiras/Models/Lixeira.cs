using System.Collections.Generic;

namespace ExLixeiras.Models
{
    public class Lixeira
    {
        public static Dictionary<int, Lixos> Lixo = new Dictionary<int, Lixos>() {
            { 1, new Casca_de_banana() },
            { 2, new Garrafa_de_vidro() },
            { 3, new Garrafa_plastica () },
            { 4, new Latinha() },
            { 5, new Pacote_de_bolacha() },
            { 6, new Papel_higienico() },
            { 7, new Papelao() },
            { 8, new Pilha() }
            
        };

    }
}