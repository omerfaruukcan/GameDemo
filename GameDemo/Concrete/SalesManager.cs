using GameDemo.Abstract;
using GameDemo.Entitites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    class SalesManager : ISalesService
    {
        NewGamer _newGamer;
        OldGamer _oldGamer;

        public SalesManager(OldGamer oldGamer)
        {
            _oldGamer = oldGamer;
        }

        public SalesManager(NewGamer newGamer)
        {
            _newGamer = newGamer;
        }

        public void Buy(Game game)
        {
            Console.WriteLine("Oyun Satin Alindi: " + game.Name);
        }

        public void BuyAtDiscount(Game game, GameCustomer gameCustomer)
        {
            if (gameCustomer == _newGamer)
            {
                Console.WriteLine(game.Name + "' nin Size Ozel Indirimli Fiyati: " + (game.UnitPrice - ((game.UnitPrice * 30) / 100 )));
            }
            else if (gameCustomer == _oldGamer)
            {
                Console.WriteLine("Bu kampanyadan sadece yeni musteriler yararlanabilir.");
            }
        }
    }
}
