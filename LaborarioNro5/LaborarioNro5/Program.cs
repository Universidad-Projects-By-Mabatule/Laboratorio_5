using System;

namespace LaborarioNro5
{
    class Program
    {
        static void Main(string[] args)
        {
         

            FriendList friends = new FriendList();
            friends.Add("Carlos",50,99);
            friends.Add("Jose", 70,90);
            friends.Add("Pepe",75,80);
            friends.Add("Farit",60,80);
             
            Console.WriteLine("*******************");
            Console.WriteLine("TIPO DE ESTRATEGIA");
            friends.SetEstrategia(new JuegoDefensa());
            friends.Estrategia();
            Console.WriteLine("*******************");
            Console.WriteLine("TIPO DE ESTRATEGIA");
            friends.SetEstrategia(new JuegoAtaque());
            friends.Estrategia();
        }
    }
}
