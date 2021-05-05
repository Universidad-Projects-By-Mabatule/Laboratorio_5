using System;
using System.Collections.Generic;
using System.Text;

namespace LaborarioNro5
{
    public class Jugador
    {
        private string _nombre;
        private int _aim;
        private int _recoil;

        public Jugador(string nombre,int aim,int recoil)
        {
            _nombre = nombre; 
            _aim = aim;
            _recoil = recoil;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Aim { get => _aim; set => _aim = value; }
        public int Recoil { get => _recoil; set => _recoil = value; }

        public void Datos()
        {
            Console.WriteLine("Nombre: {0} ", Nombre);
            Console.WriteLine("Aim: {0} %", Aim); 
            Console.WriteLine("Recoil: {0} %", Recoil);
        }
       
    }
}
