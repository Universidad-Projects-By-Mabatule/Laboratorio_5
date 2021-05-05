using System;
using System.Collections.Generic;
using System.Text;

namespace LaborarioNro5
{
    public interface IJuego
    {
        public List<Jugador> Posiciones(List<Jugador> list);
        public void Mod();
    }
}
