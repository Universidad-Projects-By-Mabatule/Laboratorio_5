using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace LaborarioNro5
{
    class JuegoDefensa:IJuego
    {
        public List<Jugador> Posiciones(List<Jugador> lista)
        {
            List<Jugador> listaAux = lista.OrderByDescending(jugador => jugador.Recoil).ToList();        
            return listaAux;
        }
        public void Mod()
        {
            Console.WriteLine("Posiciones modo Defensa");
        }
    }
}
