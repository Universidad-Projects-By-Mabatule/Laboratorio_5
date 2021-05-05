using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace LaborarioNro5
{
    public class JuegoAtaque:IJuego
    {
        public List<Jugador> Posiciones(List<Jugador> lista)
        {
            List<Jugador> listAux = lista.OrderBy(jugador => jugador.Aim).ToList();
            return listAux;
        }
        public void Mod()
        {
            Console.WriteLine("Posiciones modo Ataque");
        }
    }
}
 