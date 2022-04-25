using GameDemo.Abstract;
using GameDemo.Entitites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void SignUp(GameCustomer gameCustomer)
        {
            _userValidationService.Validate(gameCustomer);
        }

        public void Update(OldGamer gamer)
        {
            Console.WriteLine("Kayit guncellendi");
        }

        public void Delete(OldGamer gamer)
        {
            Console.WriteLine("Kayit silindi");
        }
    }
}
