using System;
using System.Collections.Generic;
using System.Text;

namespace LaborarioNro5
{
    class FriendList
    {
        private List<Jugador> _list = new List<Jugador>();
        private IJuego _juegostrategy; 

        public void SetEstrategia(IJuego juegostrategy)
        {
            this._juegostrategy = juegostrategy; 
        }

        public void Add(string name, int aim, int recoil)
        {
            _list.Add(new Jugador(name, aim,recoil));
        }
        public void Mostrar()
        {
            foreach (Jugador jugador in _list)
            {
                jugador.Datos();
                Console.WriteLine("*******************");
            }
        }
        public void Estrategia()
        {
            _list=_juegostrategy.Posiciones(_list);
            Mostrar();
        }
    }
}
