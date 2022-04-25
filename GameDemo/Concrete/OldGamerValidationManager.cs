using GameDemo.Abstract;
using GameDemo.Entitites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class OldGamerValidationManager : IUserValidationService
    {
        NewGamer _newGamer;

        public OldGamerValidationManager(NewGamer newGamer)
        {
            _newGamer = newGamer;
        }

        OldGamer _oldGamer;

        public OldGamerValidationManager(OldGamer oldGamer)
        {
            _oldGamer = oldGamer;
        }

        public bool Validate(GameCustomer gameCustomer)
        {
            if (gameCustomer == _oldGamer)
            {
                if (_oldGamer.UserName == "ofarukcan" && _oldGamer.Password == "12345abc")
                {
                    Console.WriteLine("Sisteme Hosgeldiniz");
                    return true;
                }
                else
                {
                    Console.WriteLine("Yanlis kullanici adi veya sifre");
                    return false;
                }
            }
            else if (gameCustomer == _newGamer)
            {
                Console.WriteLine("Sistemimize kayitli boyle bir kullanici bulunmamaktadir");
                return false;
            }
            else
            {
                Console.WriteLine("Hatali bir islem yaptiniz.");
                return false;
            }
        }
    }
}
