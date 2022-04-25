using GameDemo.Abstract;
using GameDemo.Concrete;
using GameDemo.Entitites;
using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            OldGamer oldGamer = new OldGamer
            {
                UserName = "ofarukcan",
                Password = "12345abc"
            };

            NewGamer newGamer = new NewGamer
            {
                FirstName = "Omer Faruk",
                DateOfBirth = 1998
            };

            GamerManager gamerManager = new GamerManager(new OldGamerValidationManager(oldGamer));
            gamerManager.SignUp(oldGamer);
            gamerManager.Update(oldGamer);
            gamerManager.Delete(oldGamer);

            GamerManager gamerManager1 = new GamerManager(new NewGamerValidationManager(newGamer));
            gamerManager1.SignUp(newGamer);

            Console.WriteLine("-------------------------");

            Game game = new Game
            {
                Name = "FIFA22",
                UnitPrice = 150
            };


            SalesManager salesManager = new SalesManager(newGamer);
            salesManager.Buy(game);
            salesManager.BuyAtDiscount(game, newGamer);
        }
    }
}
